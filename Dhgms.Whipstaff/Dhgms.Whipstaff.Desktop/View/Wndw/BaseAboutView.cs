using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.Whipstaff.Desktop.View.Wndw
{
    using Dhgms.Whipstaff.Core.ViewModels;
    using Dhgms.Whipstaff.Desktop.Controls;

    public class BaseAboutView : WhipstaffMetroWindow<BaseAboutView, IAboutViewModel>
    {
        public BaseAboutView(IAboutViewModel viewModel)
            : base(viewModel)
        {
        }
    }
}
