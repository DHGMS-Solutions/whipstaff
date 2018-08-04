namespace Dhgms.Whipstaff.Desktop.View.Wndw
{
    using Dhgms.Whipstaff.Core.ViewModels;
    using Dhgms.Whipstaff.Desktop.Controls;

    public class BaseDiagnosticView : WhipstaffMetroWindow<BaseDiagnosticView, IDiagnosticViewModel>
    {
        public BaseDiagnosticView(IDiagnosticViewModel viewModel)
            : base(viewModel)
        {
        }
    }
}
