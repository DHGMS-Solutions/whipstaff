namespace Dhgms.Whipstaff.Showcase.Desktop.ViewModel
{
    using System.Collections.Generic;

    using Dhgms.Whipstaff.Showcase.Desktop.ViewModel.Interface;

    using ReactiveUI;

    public class TicketListViewModel : ReactiveObject, ITicketListViewModel, IRoutableViewModel
    {
        public string UrlPathSegment
        {
            get
            {
                return "TicketList";
            }
        }

        public IScreen HostScreen { get; protected set; }

        public List<int> Tickets { get; set; }
    }
}
