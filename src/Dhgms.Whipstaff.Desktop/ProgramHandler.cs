//namespace Dhgms.Whipstaff.Model
//{
//    using System;
//    using System.Collections.Generic;
//    using System.Linq;
//    using System.Text;
//    using System.Timers;
//    using System.Windows.Forms;
//    using System.Windows.Shell;

//    using Dhgms.Whipstaff.Model.Info;
//    using Dhgms.Whipstaff.View.Wndw;

//    using Microsoft.WindowsAPICodePack.ApplicationServices;
//    using MS.WindowsAPICodePack.Internal;

//    using SplashScreen = System.Windows.SplashScreen;
//    using Timer = System.Windows.Forms.Timer;

//    /// <summary>
//    /// The program handler.
//    /// </summary>
//    /// <typeparam name="TMainWindowType">
//    /// The type representing the main window
//    /// </typeparam>
//    /// <typeparam name="TChildWindowType">
//    /// The type representing the base child window
//    /// </typeparam>
//    /// <typeparam name="TSystemNotificationAreaControllerType">
//    /// The type representing the System Notification Area controller
//    /// </typeparam>
//    public abstract class ProgramHandler<TMainWindowType, TChildWindowType, TSystemNotificationAreaControllerType>
//        where TMainWindowType : System.Windows.Window, new()
//        where TChildWindowType : System.Windows.Window, new()
//        where TSystemNotificationAreaControllerType : SystemNotificationArea<>, new()
//    {
//        /// <summary>
//        /// Whether the program is in multi-screen mode
//        /// </summary>
//        protected readonly bool MultiScreenMode;

//        /// <summary>
//        /// Command Line Arguments
//        /// </summary>
//        protected readonly CommandLineArguments CommandLineArguments;

//        /// <summary>
//        /// List of main windows for the application, by default 1 per screen
//        /// </summary>
//        protected List<TMainWindowType> MainWindows;

//        /// <summary>
//        /// List of child windows for the application
//        /// </summary>
//        protected readonly List<TChildWindowType> ChildWindows;

//        /// <summary>
//        /// Controller for the System Notification Area icon
//        /// </summary>
//        protected TSystemNotificationAreaControllerType SystemNotificationArea;

//        /// <summary>
//        /// Whether to show the Recent Jump List Category
//        /// </summary>
//        private readonly bool showRecentJumpListCategory;

//        /// <summary>
//        /// Whether to use Speech Announcements
//        /// </summary>
//        private readonly bool useSpeechAnnouncements;

//        /// <summary>
//        /// Initializes a new instance of the <see cref="ProgramHandler{TMainWindowType,TChildWindowType,TSystemNotificationAreaControllerType}"/> class.
//        /// </summary>
//        /// <param name="multiScreenMode">
//        /// Whether the program is to use multi screen support
//        /// </param>
//        /// <param name="showRecentJumpListCategory">
//        /// Whether the jump list will show recent items
//        /// </param>
//        /// <param name="useSpeechAnnouncements">
//        /// Whether to use Speech Announcements
//        /// </param>
//        protected ProgramHandler(bool multiScreenMode, bool showRecentJumpListCategory, bool useSpeechAnnouncements)
//        {
//            this.MultiScreenMode = multiScreenMode;
//            this.ChildWindows = new List<TChildWindowType>();
//            this.useSpeechAnnouncements = useSpeechAnnouncements;

//            this.CommandLineArguments = new CommandLineArguments();
//            this.showRecentJumpListCategory = showRecentJumpListCategory;

//            this.IsRunningUnderClickOnce = AppDomain.CurrentDomain.ActivationContext != null;
//        }

//        protected bool IsRunningUnderClickOnce
//        {
//            get; private set;
//        }

//        /// <summary>
//        /// Entry point for doing the donkey work.
//        /// </summary>
//        public void Execute()
//        {
//            if (this.GetIsFirstProgramInstance())
//            {
//                RegisterApplicationRecoveryAndRestart();
//                SplashScreen splash = null;
//                if (this.CommandLineArguments.ShowSplashScreen)
//                {
//                    splash = new SplashScreen("splashscreen.png");
//                    splash.Show(false, true);
//                }

//                this.DoBackgroundInitialisation(this.CommandLineArguments);

//                if (splash != null)
//                {
//                    splash.Close(new TimeSpan(0));
//                }

//                if (this.CommandLineArguments.IsProtocolUrlCall)
//                {
//                    this.DoProtocolLaunch();
//                }

//                // this is done here so random windows don't appear
//                // one at a time while the splash screen is up
//                foreach (var win in this.MainWindows)
//                {
//                    win.Show();
//                }

//                System.Windows.Application.Current.Run();

//                UnregisterApplicationRecoveryAndRestart();
//            }
//            else
//            {
//                if (this.CommandLineArguments.IsProtocolUrlCall)
//                {
//                    this.TellFirstInstanceOfProtocolLaunch();
//                }
//            }

//        }

//        private void TellFirstInstanceOfProtocolLaunch()
//        {
//            throw new NotImplementedException();
//        }

//        private static void UnregisterApplicationRecoveryAndRestart()
//        {
//            if (!CoreHelpers.RunningOnVista)
//            {
//                return;
//            }

//            ApplicationRestartRecoveryManager.UnregisterApplicationRestart();
//            ApplicationRestartRecoveryManager.UnregisterApplicationRecovery();
//        }

//        private static void RegisterApplicationRecoveryAndRestart()
//        {
//            if (!CoreHelpers.RunningOnVista)
//            {
//                return;
//            }

//            var restartSettings = new RestartSettings(string.Empty, RestartRestrictions.NotOnReboot);
//            ApplicationRestartRecoveryManager.RegisterForApplicationRestart(restartSettings);

//            RecoverySettings recoverySettings =
//                new RecoverySettings(new RecoveryData(OnApplicationRecovery, null), 5000);
//            ApplicationRestartRecoveryManager.RegisterForApplicationRecovery(recoverySettings);
//        }

//        private static int OnApplicationRecovery(object state)
//        {
//            try
//            {
//                var pinger = new System.Timers.Timer(4000);
//                pinger.Elapsed += PingSystem;
//                pinger.Enabled = true;
//                ApplicationRestartRecoveryManager.ApplicationRecoveryInProgress();

//                DoApplicationRecovery(state);

//                pinger.Elapsed -= PingSystem;

//                ApplicationRestartRecoveryManager.ApplicationRecoveryFinished(true);
//            }
//            catch
//            {
//                ApplicationRestartRecoveryManager.ApplicationRecoveryFinished(false);
//            }

//            return 0;
//        }

//        private static void PingSystem(object source, ElapsedEventArgs e)
//        {
//            ApplicationRestartRecoveryManager.ApplicationRecoveryInProgress();
//        }


//        private static void DoApplicationRecovery(object state)
//        {
//        }

//        /// <summary>
//        /// Checks if this launch is the first instance of the program
//        /// </summary>
//        /// <returns>
//        /// Whether this is the first instance
//        /// </returns>
//        private bool GetIsFirstProgramInstance()
//        {
//            return false;
//        }

//        /// <summary>
//        /// Handle a URL Protocol call to the program
//        /// </summary>
//        protected abstract void DoProtocolLaunch();

//        private void DoBackgroundInitialisation(CommandLineArguments commandLineArguments)
//        {
//            try
//            {
//                new Helper.SystemIntegrity().CheckOk();

//                // TODO: Reactive Extensions
//                // TODO: pushing child windows between the different windows
//                // TODO: logging console
//                // TODO: fullscreen single window
//                // TODO: fullscreen multiple windows
//                // TODO: hide \ show window
//                // TODO: group policy

//                // feature sets will be used for jump lists etc.
//                this.DoOperatingSystemFeatureSets();
//                this.DoMainWindowInitialisation();
//            }
//            catch (System.Exception)
//            {
//            }
//        }

//        private void DoMainWindowInitialisation()
//        {
//            var screens = Screen.AllScreens;

//            var screenCount = this.MultiScreenMode ? screens.Length : 1;
//            this.MainWindows = new List<TMainWindowType>();

//            double height = 0;
//            double width = 0;

//            // check if we have a default behaviour specified in group policy
//            // check if we have a /resetui command line argument
//            var groupPolicyWindowSettings = new Info.GroupPolicy.Window();
//            if (!groupPolicyWindowSettings.AlwaysUseDefaultHeights && !this.CommandLineArguments.ResetUi)
//            {
//                // TODO: load the window information from the registry
//            }

//            for (int screenNumber = 0; screenNumber < screenCount; screenNumber++)
//            {
//                var s = screens[screenNumber];
//                var workingArea = s.WorkingArea;

//                if (!SystemInformation.MonitorsSameDisplayFormat || height.Equals(0) || width.Equals(0))
//                {
//                    // we may only need to work out the dimensions once
//                    width = workingArea.Width * 0.75;
//                    height = workingArea.Width * 0.75;
//                }

//                var currentWindow = new TMainWindowType { Left = workingArea.Left + 1, Top = workingArea.Top + 1, Width = width, Height = height };

//                this.MainWindows.Add(currentWindow);
//            }
//        }

//        private void DoOperatingSystemFeatureSets()
//        {
//            // We use single place for pre-processor directive so that the
//            // method will be empty if we don't want to use the features
//            // and thus gets optimised out.
//            var featureSet = this.GetOperatingSystemFeatureSet();

//            DoSpeechSynthesis(featureSet);
//            switch (featureSet)
//            {
//                case OperatingSystemFeatureSet.WindowsVistaOrLater:
//                    this.DoWindowsLegacyFeatureSet(featureSet);
//                    this.DoWindowsVistaFeatureSet(featureSet);
//                    break;

//                case OperatingSystemFeatureSet.Windows7OrLater:
//                    this.DoWindowsLegacyFeatureSet(featureSet);
//                    this.DoWindowsVistaFeatureSet(featureSet);
//                    this.DoWindows7FeatureSet(featureSet);
//                    break;

//                case OperatingSystemFeatureSet.Windows8OrLater:
//                    this.DoWindowsLegacyFeatureSet(featureSet);
//                    this.DoWindowsVistaFeatureSet(featureSet);
//                    this.DoWindows7FeatureSet(featureSet);
//                    this.DoWindows8FeatureSet(featureSet);
//                    break;

//                default:
//                    this.DoWindowsLegacyFeatureSet(featureSet);
//                    break;
//            }
//        }

//        /// <summary>
//        /// Initialises the Legacy Windows Feature sets
//        /// </summary>
//        /// <param name="actualFeatureSet">The actual feature set available, can be used if we prefer to use a later OS feature instead of an earlier feature</param>
//        private void DoWindowsLegacyFeatureSet(OperatingSystemFeatureSet actualFeatureSet)
//        {
//            //if (actualFeatureSet != OperatingSystemFeatureSet.None)
//            //{
//                // we'll use jump lists instead of SNA on later OS?
//                // Set up SNA
//                this.SystemNotificationArea = new TSystemNotificationAreaControllerType();
//            //}
//        }

//        /// <summary>
//        /// Initialises the Windows Vista feature sets
//        /// </summary>
//        /// <param name="actualFeatureSet">The actual feature set available, can be used if we prefer to use a later OS feature instead of an earlier feature</param>
//        private void DoWindowsVistaFeatureSet(OperatingSystemFeatureSet actualFeatureSet)
//        {
//        }

//        private void DoSpeechSynthesis(OperatingSystemFeatureSet actualFeatureSet)
//        {
//            this.SpeechAnnouncements = new SpeechAnnouncements(actualFeatureSet, this.useSpeechAnnouncements);
//        }

//        public SpeechAnnouncements SpeechAnnouncements
//        {
//            get;
//            private set;
//        }

//        /// <summary>
//        /// Initialises the Windows 8 feature sets
//        /// </summary>
//        /// <param name="actualFeatureSet">The actual feature set available, can be used if we prefer to use a later OS feature instead of an earlier feature</param>
//        private void DoWindows8FeatureSet(OperatingSystemFeatureSet actualFeatureSet)
//        {
//        }

//        /// <summary>
//        /// Initialises the Windows 7 feature sets
//        /// </summary>
//        /// <param name="actualFeatureSet">The actual feature set available, can be used if we prefer to use a later OS feature instead of an earlier feature</param>
//        private void DoWindows7FeatureSet(OperatingSystemFeatureSet actualFeatureSet)
//        {
//            DoJumpTasks();
//        }

//        private void DoJumpTasks()
//        {
//            var jumpListTasks = GetJumpListTasks();

//            if (!jumpListTasks.Any() && !this.showRecentJumpListCategory)
//            {
//                return;
//            }

//            var jumpList = new JumpList
//            {
//                ShowRecentCategory = this.showRecentJumpListCategory
//            };

//            jumpList.JumpItems.AddRange(this.GetJumpListTasks());

//            JumpList.SetJumpList(System.Windows.Application.Current, jumpList);
//        }

//        protected abstract IEnumerable<JumpItem> GetJumpListTasks();

//        /// <summary>
//        /// </summary>
//        /// <returns>
//        /// </returns>
//        private OperatingSystemFeatureSet GetOperatingSystemFeatureSet()
//        {
//            if (Environment.OSVersion.Version.Major > 6)
//            {
//                return OperatingSystemFeatureSet.Windows8OrLater;
//            }

//            if (Environment.OSVersion.Version.Major == 6)
//            {
//                switch (Environment.OSVersion.Version.Minor)
//                {
//                    case 0:
//                        return OperatingSystemFeatureSet.WindowsVistaOrLater;
//                    case 1:
//                        return OperatingSystemFeatureSet.Windows7OrLater;
//                    default:
//                        return OperatingSystemFeatureSet.Windows8OrLater;
//                }
//            }

//            return OperatingSystemFeatureSet.None;
//        }
//    }
//}
