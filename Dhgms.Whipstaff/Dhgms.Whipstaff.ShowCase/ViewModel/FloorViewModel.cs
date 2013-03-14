using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.Whipstaff.ShowCase.ViewModel
{
    using ReactiveUI;
    using ReactiveUI.Routing;

    public class FloorViewModel : ReactiveObject, IFloorViewModel, IRoutableViewModel
    {
        public string UrlPathSegment
        {
            get
            {
                return "FloorView";
            }
        }

        public IScreen HostScreen { get; protected set; }

        public string BuildingName { get; set; }

        public string FloorName { get; set; }

        public List<TeamViewModel> Teams { get; set; }
    }
}
