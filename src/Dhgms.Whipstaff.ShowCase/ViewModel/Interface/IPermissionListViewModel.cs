using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.Whipstaff.ShowCase.ViewModel.Interface
{
    interface IPermissionListViewModel
    {
        IList<string> Roles { get; set; }
    }
}
