namespace Dhgms.Whipstaff.Showcase.Desktop.ViewModel
{
    using System.Collections.Generic;

    using Dhgms.Whipstaff.Showcase.Desktop.ViewModel.Interface;

    using ReactiveUI;

    public class ServerSelectionViewModel : ReactiveObject, IServerSelectionViewModel, IRoutableViewModel
    {
        public string UrlPathSegment
        {
            get
            {
                return "ServerSelection";
            }
        }

        public IScreen HostScreen { get; protected set; }

        public IList<IServerViewModel> Servers { get; set; }
    }
}
