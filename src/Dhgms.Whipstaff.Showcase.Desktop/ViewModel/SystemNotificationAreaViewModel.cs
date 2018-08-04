namespace Dhgms.Whipstaff.Showcase.Desktop.ViewModel
{
    using System;
    using System.Reactive;
    using System.Threading.Tasks;
    using System.Windows.Controls;
    using System.Windows.Input;

    using Dhgms.Whipstaff.Showcase.Desktop.Model;

    using ReactiveUI;

    public class SystemNotificationAreaViewModel : ReactiveObject /*ISystemNotificationAreaViewModel,*/ //IRoutableViewModel
    {
        private static ContextMenu contextMenu;

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemNotificationAreaViewModel"/> class.
        /// </summary>
        public SystemNotificationAreaViewModel()
        {
            this.IconFileUri = "pack://application:,,,/Resource/Icon/sna.ico";

            this.ShowApplicationCommand = ReactiveCommand.CreateAsyncTask(async _ => await OnShowApplication());

            this.ExitApplicationCommand = ReactiveCommand.CreateAsyncTask(async _ => await OnExitApplication());
        }

        private Task<Unit> OnShowApplication()
        {
            throw new NotImplementedException();
        }

        //public string UrlPathSegment { get; private set; }

        //public IScreen HostScreen { get; private set; }

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
                return contextMenu;
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

        protected ReactiveCommand<Unit> ExitApplicationCommand { get; set; }

        protected ReactiveCommand<Unit> ShowApplicationCommand
        {
            get;
            private set;
        }

        private Task OnExitApplication()
        {
            //Application.ExitApplication();
            throw new NotImplementedException();
        }
        /*
        private async Task OnShowApplication()
        {
            //Application.ShowApplicationWindows();
            throw new NotImplementedException();
        }
         * */

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
