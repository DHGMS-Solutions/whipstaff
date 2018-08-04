using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.Whipstaff.Showcase.Desktop.View
{
    using Dhgms.Whipstaff.Desktop.Controls;
    using Dhgms.Whipstaff.Showcase.Desktop.ViewModel;

    public class DeveloperConsoleViewBase : WhipstaffMetroWindow<DeveloperConsoleViewBase, DeveloperConsoleViewModel>
    {
        public DeveloperConsoleViewBase(DeveloperConsoleViewModel viewModel)
            : base(viewModel)
        {
        }
    }
}
