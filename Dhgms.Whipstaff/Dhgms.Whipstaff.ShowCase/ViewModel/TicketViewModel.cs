using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.Whipstaff.ShowCase.ViewModel
{
    using ReactiveUI;
    using ReactiveUI.Routing;

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
