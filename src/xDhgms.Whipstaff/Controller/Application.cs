﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Application.cs" company="DHGMS Solutions">
//   Copyright 2012. Some Rights Reserved.
// </copyright>
// <summary>
//   The application.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.Whipstaff.Controller
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Windows;
    using System.Windows.Forms;

    using Dhgms.Whipstaff.Model.Info;
    using Dhgms.Whipstaff.Model.SingleInstance;
    using Dhgms.Whipstaff.View.Wndw;
    using Dhgms.Whipstaff.ViewModel;

    using MS.WindowsAPICodePack.Internal;

    using ReactiveUI;

    using MessageBox = System.Windows.MessageBox;

    /// <summary>
    /// The application.
    /// </summary>
    /// <typeparam name="TSplashScreenClass">
    /// The type for the splash screen class.
    /// </typeparam>
    /// <typeparam name="TMainWindowClass">
    /// The type for the main window class.
    /// </typeparam>
    /// <typeparam name="TSystemNotificationAreaViewModel">
    /// The type for the system notification area view model.
    /// </typeparam>
    public abstract class Application<TSplashScreenClass, TMainWindowClass, TSystemNotificationAreaViewModel> : System.Windows.Application
        where TSplashScreenClass : Window, new()
        where TMainWindowClass : Window, new()
        where TSystemNotificationAreaViewModel : ReactiveObject, ISystemNotificationAreaViewModel, IRoutableViewModel, new()
    {
        /// <summary>
        /// Whether the program is in multi-screen mode
        /// </summary>
        protected readonly bool MultiScreenMode;

        /// <summary>
        /// Whether to allow multiple instances of a program
        /// </summary>
        private readonly bool allowMultipleInstances;

        /// <summary>
        /// Whether to always show the system notification area
        /// </summary>
        private readonly bool alwaysShowSystemNotificationArea;

        /// <summary>
        /// Main Window Class
        /// </summary>
        private List<TMainWindowClass> mainWindows;

        /// <summary>
        /// System Notification Area Class
        /// </summary>
        private SystemNotificationArea systemNotificationArea;

        //private TaskbarManager taskbarManager = TaskbarManager.Instance;

// ReSharper disable NotAccessedField.Local
        /// <summary>
        /// Manager for ensuring single instance of application.
        /// </summary>
        private SingleInstanceManager manager;
// ReSharper restore NotAccessedField.Local

        /// <summary>
        /// The application unique id
        /// </summary>
        private Guid applicationId;

        /// <summary>
        /// Initializes a new instance of the <see cref="Application{TSplashScreenClass,TMainWindowClass,TSystemNotificationAreaViewModel, TCommandLineArgumentsClass, TRemoteCommandHandlerClass}"/> class. 
        /// </summary>
        /// <param name="applicationId">
        /// The application Id.
        /// </param>
        /// <param name="multiScreenMode">
        /// Whether the program is to use multi screen support
        /// </param>
        /// <param name="allowMultipleInstances">
        /// Whether the program allows multiple instances
        /// </param>
        /// <param name="alwaysShowSystemNotificationArea">
        /// Whether to always Show System Notification Area.
        /// </param>
        protected Application(Guid applicationId, bool multiScreenMode, bool allowMultipleInstances, bool alwaysShowSystemNotificationArea)
        {
            if (applicationId.Equals(Guid.Empty))
            {
                throw new ArgumentException("application id is empty", "applicationId");
            }

            this.applicationId = applicationId;

            this.MultiScreenMode = multiScreenMode;
            this.allowMultipleInstances = allowMultipleInstances;
            this.alwaysShowSystemNotificationArea = alwaysShowSystemNotificationArea;
        }

        /// <summary>
        /// Shows the application windows.
        /// </summary>
        public static void ShowApplicationWindows()
        {
            var instance = (Application<TSplashScreenClass, TMainWindowClass, TSystemNotificationAreaViewModel>)Current;

            foreach (var win in instance.mainWindows)
            {
                win.Activate();
            }
        }

        /// <summary>
        /// The exit application call.
        /// </summary>
        public static void ExitApplication()
        {
            var instance = (Application<TSplashScreenClass, TMainWindowClass, TSystemNotificationAreaViewModel>)Current;
            instance.ActuallyCloseWindows();
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Application.Startup"/> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.StartupEventArgs"/> that contains the event data.</param>
        protected override void OnStartup(System.Windows.StartupEventArgs e)
        {
            base.OnStartup(e);

            if (!this.allowMultipleInstances)
            {
                // this will exit the program if an instance already exists
                this.manager = SingleInstanceManager.Initialize(this.GetSingleInstanceManagerSetup());
            }

            TSplashScreenClass splash = null;
            //if (this.CommandLineArguments.ShowSplashScreen)
            //{
                splash = new TSplashScreenClass();
                splash.Show();
            //}

            this.DoInitialisation();

            if (splash != null)
            {
                splash.Close();
            }

            // this is done here so random windows don't appear
            // one at a time while the splash screen is up
            foreach (var win in this.mainWindows)
            {
                win.Show();
            }
        }

        /// <summary>
        /// Performs initialization.
        /// </summary>
        protected void DoInitialisation()
        {
            new Model.Helper.SystemIntegrity().CheckOk();

            // TODO: Reactive Extensions
            // TODO: pushing child windows between the different windows
            // TODO: logging console
            // TODO: fullscreen single window
            // TODO: fullscreen multiple windows
            // TODO: hide \ show window
            // TODO: group policy

            // feature sets will be used for jump lists etc.
            this.DoOperatingSystemFeatureSets();
            this.DoMainWindowInitialisation();
        }

        /// <summary>
        /// Event Handler for when a second instance of an application starts and needs to pass information to this one.
        /// </summary>
        /// <param name="args">
        /// Collection of arguments
        /// </param>
        protected abstract void OnRemoteInstanceCommandRecieved(string[] args);

        /// <summary>
        /// Gets the feature set the operating system supports
        /// </summary>
        /// <returns>
        /// The <see cref="OperatingSystemFeatureSet"/>.
        /// </returns>
        private static OperatingSystemFeatureSet GetOperatingSystemFeatureSet()
        {
            if (Environment.OSVersion.Version.Major > 6)
            {
                return OperatingSystemFeatureSet.Windows8OrLater;
            }

            if (Environment.OSVersion.Version.Major == 6)
            {
                switch (Environment.OSVersion.Version.Minor)
                {
                    case 0:
                        return OperatingSystemFeatureSet.WindowsVistaOrLater;
                    case 1:
                        return OperatingSystemFeatureSet.Windows7OrLater;
                    default:
                        return OperatingSystemFeatureSet.Windows8OrLater;
                }
            }

            return OperatingSystemFeatureSet.None;
        }

        /// <summary>
        /// Initializes the main window.
        /// </summary>
        private void DoMainWindowInitialisation()
        {
            var screens = Screen.AllScreens;

            var screenCount = this.MultiScreenMode ? screens.Length : 1;
            this.mainWindows = new List<TMainWindowClass>();

            double height = 0;
            double width = 0;

            // check if we have a default behaviour specified in group policy
            // check if we have a /resetui command line argument
            /*
            var groupPolicyWindowSettings = new WpfSample.Model.Info.GroupPolicy.Window();
            if (!groupPolicyWindowSettings.AlwaysUseDefaultHeights && !this.CommandLineArguments.ResetUi)
            {
                // TODO: load the window information from the registry
            }
             * */

            for (var screenNumber = 0; screenNumber < screenCount; screenNumber++)
            {
                var s = screens[screenNumber];
                var workingArea = s.WorkingArea;

                if (!SystemInformation.MonitorsSameDisplayFormat || height.Equals(0) || width.Equals(0))
                {
                    // we may only need to work out the dimensions once
                    width = workingArea.Width * 0.75;
                    height = workingArea.Height * 0.75;
                }

                var currentWindow = new TMainWindowClass { Left = workingArea.Left + 1, Top = workingArea.Top + 1, Width = width, Height = height };
                currentWindow.Closing += this.MainWindowOnClosing;

                this.mainWindows.Add(currentWindow);
            }
        }

        /// <summary>
        /// The main window on closing event.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void MainWindowOnClosing(object sender, CancelEventArgs e)
        {
            // we only want to hide windows if the SNA exists
            if (this.systemNotificationArea != null)
            {
                e.Cancel = true;
                ((Window)sender).Hide();
            }
        }

        /// <summary>
        /// Performs the operating system feature sets.
        /// </summary>
        private void DoOperatingSystemFeatureSets()
        {
            // We use single place for pre-processor directive so that the
            // method will be empty if we don't want to use the features
            // and thus gets optimised out.
            var featureSet = GetOperatingSystemFeatureSet();

            switch (featureSet)
            {
                case OperatingSystemFeatureSet.WindowsVistaOrLater:
                    this.DoWindowsLegacyFeatureSet(featureSet);
                    this.DoWindowsVistaFeatureSet(featureSet);
                    break;
                case OperatingSystemFeatureSet.Windows7OrLater:
                    this.DoWindowsLegacyFeatureSet(featureSet);
                    this.DoWindowsVistaFeatureSet(featureSet);
                    this.DoWindows7FeatureSet(featureSet);
                    break;
                case OperatingSystemFeatureSet.Windows8OrLater:
                    this.DoWindowsLegacyFeatureSet(featureSet);
                    this.DoWindowsVistaFeatureSet(featureSet);
                    this.DoWindows7FeatureSet(featureSet);
                    this.DoWindows8FeatureSet(featureSet);
                    break;
                default:
                    this.DoWindowsLegacyFeatureSet(featureSet);
                    break;
            }
        }

        /// <summary>
        /// Initializes the Legacy Windows Feature sets
        /// </summary>
        /// <param name="actualFeatureSet">The actual feature set available, can be used if we prefer to use a later OS feature instead of an earlier feature</param>
        private void DoWindowsLegacyFeatureSet(OperatingSystemFeatureSet actualFeatureSet)
        {
            if (actualFeatureSet == OperatingSystemFeatureSet.None || this.alwaysShowSystemNotificationArea)
            {
                // we'll use jump lists instead of SNA on later OS?
                // Set up SNA
                this.systemNotificationArea = new SystemNotificationArea
                {
                    DataContext = new TSystemNotificationAreaViewModel()
                };
            }
        }

        /// <summary>
        /// Initializes the Windows Vista feature sets
        /// </summary>
        /// <param name="actualFeatureSet">The actual feature set available, can be used if we prefer to use a later OS feature instead of an earlier feature</param>
        private void DoWindowsVistaFeatureSet(OperatingSystemFeatureSet actualFeatureSet)
        {
        }

        /// <summary>
        /// Initializes the Windows 8 feature sets
        /// </summary>
        /// <param name="actualFeatureSet">The actual feature set available, can be used if we prefer to use a later OS feature instead of an earlier feature</param>
        private void DoWindows8FeatureSet(OperatingSystemFeatureSet actualFeatureSet)
        {
        }

        /// <summary>
        /// Initializes the Windows 7 feature sets
        /// </summary>
        /// <param name="actualFeatureSet">The actual feature set available, can be used if we prefer to use a later OS feature instead of an earlier feature</param>
        private void DoWindows7FeatureSet(OperatingSystemFeatureSet actualFeatureSet)
        {
        }

        /// <summary>
        /// The get single instance manager setup.
        /// </summary>
        /// <returns>
        /// The <see cref="SingleInstanceManagerSetup"/>.
        /// </returns>
        private SingleInstanceManagerSetup GetSingleInstanceManagerSetup()
        {
            return new SingleInstanceManagerSetup(this.applicationId.ToString())
            {
                ArgumentsHandler = args => this.OnRemoteInstanceCommandRecieved(args),
                ArgumentsHandlerInvoker = new ApplicationDispatcherInvoker(),
                DelivaryFailureNotification = ex => MessageBox.Show(ex.Message, "An error occured"),
            };
        }

        private void CreateJumpList()
        {
            if (CoreHelpers.RunningOnWin7)
            {
                // string cmdPath = Assembly.GetEntryAssembly().Location;
                // JumpList jumpList = JumpList.CreateJumpList();

                /*
                JumpListCustomCategory category = new JumpListCustomCategory("Status Change");
                category.AddJumpListItems(
                    new JumpListLink(cmdPath, Status.Online.ToString()) { Arguments = Status.Online.ToString() },
                    new JumpListLink(cmdPath, Status.Away.ToString()) { Arguments = Status.Away.ToString() },
                    new JumpListLink(cmdPath, Status.Busy.ToString()) { Arguments = Status.Busy.ToString() });
                jumpList.AddCustomCategories(category);

                jumpList.Refresh();
                 * */
            }
        }

        /// <summary>
        /// Actually closes the windows instead of just hiding them.
        /// </summary>
        private void ActuallyCloseWindows()
        {
            if (this.mainWindows != null && this.mainWindows.Any())
            {
                foreach (var win in this.mainWindows)
                {
                    win.Closing -= this.MainWindowOnClosing;
                    win.Close();
                }
            }

            if (this.systemNotificationArea != null)
            {
                this.systemNotificationArea.Close();
            }
        }
    }
}
