using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.Whipstaff.ShowCase.ViewModel
{
    using ReactiveUI;

    public class DeskViewModel : ReactiveObject, IDeskViewModel, IRoutableViewModel
    {
        public string UrlPathSegment
        {
            get
            {
                return "Desk";
            }
        }

        public IScreen HostScreen { get; protected set; }
    }
}
