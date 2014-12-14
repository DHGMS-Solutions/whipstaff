namespace Dhgms.Whipstaff.Desktop.View.Wndw
{
    using Dhgms.Whipstaff.Core.ViewModels;
    using Dhgms.Whipstaff.Desktop.Controls;

    public class BaseChangeLogView : WhipstaffMetroWindow<BaseChangeLogView, IChangeLogViewModel>
    {
        public BaseChangeLogView(IChangeLogViewModel viewModel)
            : base(viewModel)
        {
        }
    }
}
