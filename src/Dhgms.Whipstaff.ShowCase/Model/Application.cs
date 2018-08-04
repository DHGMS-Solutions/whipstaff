namespace Dhgms.Whipstaff.ShowCase.Model
{
    using System;
    using System.Collections.Generic;

    using Dhgms.Whipstaff.ShowCase.View;
    using Dhgms.Whipstaff.ShowCase.ViewModel;

    /// <summary>
    /// Main Application Logic
    /// </summary>
    public class Application : Controller.Application<SplashScreen, MainWindow, SystemNotificationAreaViewModel>
    {
        private static TeamView teamView;

        private static BuildingView buildingView;

        /// <summary>
        /// Initializes a new instance of the <see cref="Application"/> class.
        /// </summary>
        protected Application()
            : base(new Guid("4758C856-FD05-4D38-84C6-1FE91B669041"), false, false, true)
        {
        }

        public static void ShowTeamView()
        {
            if (teamView == null)
            {
                teamView = new TeamView
                {
                    ViewModel = new TeamViewModel
                    {
                        Name = "Red Team",
                        Leader = new EmployeeViewModel
                        {
                            Forename = "Red",
                            Surname = "Leader"
                        },
                        Members = new List<IEmployeeViewModel>
                        {
                            new EmployeeViewModel
                                {
                                    Forename = "Red",
                                    Surname = "One"
                                },
                            new EmployeeViewModel
                                {
                                    Forename = "Red",
                                    Surname = "Two"
                                },
                            new EmployeeViewModel
                                {
                                    Forename = "Red",
                                    Surname = "Three"
                                },
                            new EmployeeViewModel
                                {
                                    Forename = "Red",
                                    Surname = "Four"
                                },
                            new EmployeeViewModel
                                {
                                    Forename = "Red",
                                    Surname = "Five"
                                },
                            new EmployeeViewModel
                                {
                                    Forename = "Red",
                                    Surname = "Six"
                                },
                            new EmployeeViewModel
                                {
                                    Forename = "Red",
                                    Surname = "Seven"
                                },
                            new EmployeeViewModel
                                {
                                    Forename = "Red",
                                    Surname = "Eight"
                                },
                            new EmployeeViewModel
                                {
                                    Forename = "Red",
                                    Surname = "Nine"
                                },
                            new EmployeeViewModel
                                {
                                    Forename = "Red",
                                    Surname = "Ten"
                                }
                        }
                    }
                };
            }

            teamView.Show();
        }

        public static void ShowBuildingView()
        {
            if (buildingView == null)
            {
                buildingView = new View.BuildingView
                {
                    ViewModel = new BuildingViewModel()
                    {
                        Name = "Cheriton Parc",
                        Floors = new List<string>
                        {
                            "Ground Floor",
                            "1st Floor",
                            "2nd Floor",
                            "Observatory"
                        }
                    }
                };
            }

            buildingView.Show();
        }

        public static void ShowEmployeeView()
        {
            
        }

        /// <summary>
        /// Event Handler for when a second instance of an application starts and needs to pass information to this one.
        /// </summary>
        /// <param name="args">
        /// Collection of arguments
        /// </param>
        protected override void OnRemoteInstanceCommandRecieved(string[] args)
        {
        }
    }
}
