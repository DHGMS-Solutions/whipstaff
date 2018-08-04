using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.Whipstaff.ShowCase.View.Generic
{
    using Dhgms.Whipstaff.ShowCase.ViewModel;
    using Dhgms.Whipstaff.View;
    using Dhgms.Whipstaff.View.Wndw;
    using Dhgms.Whipstaff.View.Wndw.Generic;

    /// <summary>
    /// Wrappers for the Generic Class. This is done because of a WPF Designer Issue in Visual Studio 2012.
    /// </summary>
    public class DepartmentView : BaseView<DepartmentView, IDepartmentViewModel, ViewModel.DepartmentViewModel>
    {
    }
}
