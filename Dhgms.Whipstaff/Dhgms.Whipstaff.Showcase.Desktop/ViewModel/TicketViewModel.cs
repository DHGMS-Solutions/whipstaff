namespace Dhgms.Whipstaff.Showcase.Desktop.ViewModel
{
    using Dhgms.Whipstaff.Showcase.Desktop.ViewModel.Interface;

    using ReactiveUI;

    public class TicketViewModel : ReactiveObject, ITicketViewModel, IRoutableViewModel
    {
        public string UrlPathSegment
        {
            get
            {
                return "TicketView";
            }
        }

        public IScreen HostScreen { get; protected set; }

        public int Ticket { get; set; }
    }
}
