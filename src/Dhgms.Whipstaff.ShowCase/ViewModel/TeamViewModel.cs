using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.Whipstaff.ShowCase.ViewModel
{
    using ReactiveUI;

    public class TeamViewModel : ReactiveObject, ITeamViewModel, IRoutableViewModel
    {
        public string UrlPathSegment
        {
            get
            {
                return "TeamView";
            }
        }

        public IScreen HostScreen { get; protected set; }

        public string Name { get; set; }

        public IEmployeeViewModel Leader { get; set; }

        public IList<IEmployeeViewModel> Members { get; set; }
    }
}
