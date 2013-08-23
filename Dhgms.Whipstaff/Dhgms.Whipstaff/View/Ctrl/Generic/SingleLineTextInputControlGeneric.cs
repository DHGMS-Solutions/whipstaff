using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.Whipstaff.View.Ctrl.Generic
{
    public class SingleLineTextInputControlGeneric : Dhgms.Whipstaff.View.Ctrl.Generic.BaseControl<SingleLineTextInputControlGeneric, ViewModel.Ctrl.SingleLineTextInputControlViewModel>
    {
        public SingleLineTextInputControlGeneric(ViewModel.Ctrl.SingleLineTextInputControlViewModel viewModel)
            : base(viewModel)
        {
        }
    }
}
