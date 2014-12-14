namespace Dhgms.Whipstaff.Desktop.View.Wndw
{
    using Dhgms.Whipstaff.Core.ViewModels;
    using Dhgms.Whipstaff.Desktop.Controls;

    public class BaseKeyboardView : WhipstaffMetroWindow<BaseKeyboardView, IKeyboardViewModel>
    {
        public BaseKeyboardView(IKeyboardViewModel viewModel)
            : base(viewModel)
        {
        }
    }
}
