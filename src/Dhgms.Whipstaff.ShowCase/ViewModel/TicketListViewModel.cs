using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.Whipstaff.ShowCase.ViewModel
{
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
