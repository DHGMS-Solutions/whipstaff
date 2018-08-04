namespace Dhgms.Whipstaff.Showcase.Desktop.ViewModel
{
    using System;
    using System.Collections.Generic;

    using Dhgms.Whipstaff.Showcase.Common;
    using Dhgms.Whipstaff.Showcase.Desktop.Model;
    using Dhgms.Whipstaff.Showcase.Desktop.View;
    using Dhgms.Whipstaff.Showcase.Desktop.ViewModel.Interface;

    using ReactiveUI;
    //using Dhgms.Whipstaff.ShowCase.Model;

    public class MainWindowViewModel : ReactiveObject, IMainWindowViewModel, IRoutableViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindowViewModel"/> class.
        /// </summary>
        public MainWindowViewModel(IShowcaseSampleService showcaseSampleService)
        {
            if (showcaseSampleService == null)
            {
                throw new ArgumentNullException("showcaseSampleService");
            }

            var crossPlatformSamples = showcaseSampleService.GetCrossPlatformSamples();
            CrossPlatformSampleCollection = new ReactiveList<string>(crossPlatformSamples);

            var nativeSamples = showcaseSampleService.GetNativeSamples();
            NativeSampleCollection = new ReactiveList<string>(nativeSamples);

            //buildingViewCommand = new ReactiveCommand();
            //buildingViewCommand.Subscribe(this.OnBuildingCommandExecuted);

            //teamViewCommand = new ReactiveCommand();
            //teamViewCommand.Subscribe(this.OnTeamViewCommandExecuted);

            //employeeViewCommand = new ReactiveCommand();
            //employeeViewCommand.Subscribe(this.OnEmployeeViewCommandExecuted);
        }

        private void OnBuildingCommandExecuted(object o)
        {
            //Application.ShowBuildingView();
        }

        private void OnTeamViewCommandExecuted(object o)
        {
            //Application.ShowTeamView();
        }

        private void OnEmployeeViewCommandExecuted(object o)
        {
            //Application.ShowEmployeeView();
        }

        public string UrlPathSegment
        {
            get
            {
                return "Main";
            }
        }

        public IScreen HostScreen { get; protected set; }

        private object objectLock = new object();

        /*
        private static ReactiveCommand buildingViewCommand;

        private static ReactiveCommand teamViewCommand;

        private List<Dhgms.Whipstaff.Model.ControlData.Button.ButtonItem> showCases = new List<ButtonItem>
        {
            new ButtonItem
                {
                    Name = "Building View",
                    Command = buildingViewCommand
                },
            new ButtonItem
                {
                    Name = "Team View",
                    Command = teamViewCommand
                },
            new ButtonItem
                {
                    Name = "Employee View",
                    Command = employeeViewCommand
                }
        };

        private BuildingView buildingView;

        private TeamView teamView;

        private static ReactiveCommand employeeViewCommand;

        public List<Dhgms.Whipstaff.Model.ControlData.Button.ButtonItem> ShowCases
        {
            get
            {
                return this.showCases;
            }
        }
         * */

        public ReactiveList<string> NativeSampleCollection { get; private set; }

        public ReactiveList<string> CrossPlatformSampleCollection { get; private set; }
    }
}
