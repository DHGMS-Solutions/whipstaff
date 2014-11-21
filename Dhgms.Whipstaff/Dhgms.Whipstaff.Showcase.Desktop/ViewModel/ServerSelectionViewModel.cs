using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.Whipstaff.ShowCase.ViewModel
{
    using Dhgms.Whipstaff.Model.Info;

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

        public IList<Server> Servers { get; set; }
    }
}
