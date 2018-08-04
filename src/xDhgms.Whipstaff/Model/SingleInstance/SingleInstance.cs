namespace Dhgms.Whipstaff.Model.SingleInstance
{
    using System;
    using System.Diagnostics;
    using System.Security.Principal;
    using System.Threading;

    using Dhgms.Whipstaff.Model.Excptn;

    public sealed class SingleInstanceManager : IDisposable
    {
        /// <summary>
        /// Disposes the instance, and releases all held resources.
        /// </summary>
        public void Dispose()
        {
            if (this.singleInstanceMutex != null)
            {
                this.singleInstanceMutex.Close();
                this.singleInstanceMutex = null;
            }
            this.strategy.Cleanup();
        }

        private SingleInstanceManager(string applicationId, Action<string[]> argumentsHandler,
            ArgumentsDeliveryStrategy strategy, Func<string, string[]> argumentsProvider,
            IArgumentsHandlerInvoker argumentsHandlerInvoker, InstanceNotificationOption instanceNotificationOption, 
            Action<Exception> deliveryFailureNotification)
        {
            this.applicationId = applicationId;
            this.argumentsHandler = argumentsHandler;
            this.strategy = strategy;
            this.argumentsProvider = argumentsProvider ?? (appId => Environment.GetCommandLineArgs());
            this.argumentsHandlerInvoker = argumentsHandlerInvoker ?? new ThreadPoolInvoker();
            this.instanceNotificationOption = instanceNotificationOption;
            this.deliveryFailureNotification = deliveryFailureNotification;
        }

        private readonly string applicationId;
        private readonly Action<string[]> argumentsHandler;
        private readonly ArgumentsDeliveryStrategy strategy;
        private readonly Func<string, string[]> argumentsProvider;
        private readonly IArgumentsHandlerInvoker argumentsHandlerInvoker;
        private readonly InstanceNotificationOption instanceNotificationOption;
        private readonly Action<Exception> deliveryFailureNotification;

        private Mutex singleInstanceMutex;

        private static DeliveryStrategyFactory GetDefaultFactory()
        {
            return new Remoting.RemotingStrategyFactory();
        }

        private static string GenerateUserLocalId(string applicationId)
        {
            return String.Format(@"{0}:{1}", Environment.UserName, applicationId);
        }

        /// <summary>
        /// Constructs and initializes a new instance of the single instance manager.
        /// </summary>
        /// <param name="setup">Setup information for the single instance manager.</param>
        /// <returns>An initialized single instance manager.</returns>
        /// <remarks>
        /// Use this method to initialize a single instance manager with the given setup information.
        /// Note that normally only one call to this method should be performed, at the beggining of the application execution.
        /// </remarks>
        public static SingleInstanceManager Initialize(SingleInstanceManagerSetup setup)
        {
            if (setup == null)
            {
                throw new ArgumentNullException("setup");
            }

            // Initialize the SingleInstanceManager instance
            DeliveryStrategyFactory factory = setup.Factory ?? GetDefaultFactory();
            var instance = new SingleInstanceManager(
                GenerateUserLocalId(setup.ApplicationId),
                setup.ArgumentsHandler,
                factory.CreateStrategy(),
                setup.ArgumentsProvider,
                setup.ArgumentsHandlerInvoker,
                setup.InstanceNotificationOption,
                setup.DelivaryFailureNotification);

            if (!instance.TryEnsureFirstInstance())
            {
                // If this is not the first application instance (another instance is already running) then we need to exit/throw
                instance.Dispose();
                instance = null;

                switch (setup.TerminationOption)
                {
                    case TerminationOption.Exit:
                        Environment.Exit(setup.ExitCode);
                        break;
                    case TerminationOption.Throw:
                        throw new ApplicationInstanceAlreadyExistsException();
                    default:
                        throw new Exception("Should never be here!");
                }
            }

            return instance;
        }

        /// <summary>
        /// Used to check if this is the first application instance, and act accordingly.
        /// </summary>
        /// <returns>true if this is the first application instance, false otherwise.</returns>
        /// <remarks>
        /// If this is the first application instance, the argument delivery strategy is initialized to listen for incoming argument notifications.
        /// Otherwise, the argument delivery strategy is used to notify the already running application instance.
        /// </remarks>
        private bool TryEnsureFirstInstance()
        {
            if (this.IsFirstApplicationInstance())
            {
                this.strategy.InitializeFirstInstance(this.applicationId, this.NotifyArgumentsReceived);
                return true;
            }
            else
            {
                try
                {
                    // There is another instance running and we must notify it
                    // with the command line arguments.
                    this.strategy.DeliverArgumentsToFirstInstance(this.applicationId, this.argumentsProvider(this.applicationId));
                }
                catch (Exception ex)
                {
                    if (this.deliveryFailureNotification != null)
                        this.deliveryFailureNotification(ex);
                }
                return false;
            }
        }

        /// <summary>
        /// Checks if an application instance was already created, and marks this as the first instance if it is not.
        /// </summary>
        /// <returns>true if this is the first application instance, false otherwise.</returns>
        private bool IsFirstApplicationInstance()
        {
            Debug.Assert(this.singleInstanceMutex == null);

            bool createdNew;
            this.singleInstanceMutex = new Mutex(true, this.applicationId, out createdNew);
            return createdNew;
        }

        /// <summary>
        /// Notifies the registered handler of the arguments recieved.
        /// </summary>
        /// <param name="args">The command line arguments recieved.</param>
        /// <param name="remoteIsAdmin">Indicates whether the remote party is an administrator.</param>
        /// <remarks>
        /// Note that notification is performed according to the <see cref="InstanceNotificationOption"/> given in the manager setup. 
        /// In addition, note that the registered handler is invoked using the handler invoker supplied upon <see cref="Initialize">initializtion</see>.
        /// </remarks>
        private void NotifyArgumentsReceived(string[] args, bool remoteIsAdmin)
        {
            if (this.instanceNotificationOption == InstanceNotificationOption.NotifyOnlyIfAdmin)
            {
                bool localIsAdmin = new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
                if (localIsAdmin && !remoteIsAdmin)
                    throw new InvalidOperationException("The remote party should posses administrative rights to contact this application instance");
            }

            if (this.argumentsHandler != null)
                this.argumentsHandlerInvoker.Invoke(this.argumentsHandler, args);
        }
    }
}
