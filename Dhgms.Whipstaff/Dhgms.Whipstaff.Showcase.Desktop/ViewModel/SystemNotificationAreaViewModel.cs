using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.Whipstaff.ShowCase.ViewModel
{
    using System.ComponentModel;
    using System.Windows.Controls;
    using System.Windows.Input;

    using Dhgms.Whipstaff.Model.ControlData.Ribbon;
    using Dhgms.Whipstaff.Model.ControlData.SystemNotificationArea;
    using Dhgms.Whipstaff.ShowCase.Model;

    using ReactiveUI;
    using ReactiveUI.Xaml;

    public class SystemNotificationAreaViewModel : ReactiveObject, Whipstaff.ViewModel.ISystemNotificationAreaViewModel, IRoutableViewModel
    {
        private readonly object lockingObject;

        private static ContextMenu contextMenu;

        private ReactiveCommand showApplicationCommand;

        private ReactiveCommand exitApplicationCommand;

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemNotificationAreaViewModel"/> class.
        /// </summary>
        public SystemNotificationAreaViewModel()
        {
            lockingObject = new object();
            this.IconFileUri = "pack://application:,,,/Resource/Icon/sna.ico";
        }

        public string UrlPathSegment { get; private set; }

        public IScreen HostScreen { get; private set; }

        public ICommand DoubleClick
        {
            get
            {
                return this.ShowApplicationCommand;
            }
        }

        public ContextMenu ContextMenu
        {
            get
            {
                if (contextMenu == null)
                {
                    lock (lockingObject)
                    {
                        LoadContextMenu();
                    }
                }

                return contextMenu;
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        private void LoadContextMenu()
        {
            contextMenu = new ContextMenu();
            var show = new MenuItem { Header = "_Show", Command = this.ShowApplicationCommand };
            var exit = new MenuItem { Header = "E_xit", Command = this.ExitApplicationCommand };

            contextMenu.Items.Add(show);
            contextMenu.Items.Add(new Separator());
            contextMenu.Items.Add(exit);
        }

        protected ReactiveCommand ExitApplicationCommand
        {
            get
            {
                if (this.exitApplicationCommand == null)
                {
                    this.exitApplicationCommand = new ReactiveCommand();
                    this.exitApplicationCommand.Subscribe(this.OnExitApplication);
                }

                return this.exitApplicationCommand;
            }
        }

        private void OnExitApplication(object value)
        {
            Application.ExitApplication();
        }

        protected ReactiveCommand ShowApplicationCommand
        {
            get
            {
                if (this.showApplicationCommand == null)
                {
                    this.showApplicationCommand = new ReactiveCommand();
                    this.showApplicationCommand.Subscribe(this.OnShowApplication);
                }

                return this.showApplicationCommand;
            }
        }

        private void OnShowApplication(object value)
        {
            Application.ShowApplicationWindows();
        }

        public string IconFileUri { get; private set; }

        public string ToolTipText
        {
            get
            {
                return "DHGMS Showcase";
            }
        }

        public void OnAllMainWindowsClosed()
        {
        }

        public System.Windows.Forms.NotifyIcon NotifyIcon { get; set; }
    }
}
