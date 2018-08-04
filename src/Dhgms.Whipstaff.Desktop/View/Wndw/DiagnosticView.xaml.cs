namespace Dhgms.Whipstaff.Desktop.View.Wndw
{
    using Dhgms.Whipstaff.Core.ViewModels;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class DiagnosticView
    {
        public DiagnosticView(IDiagnosticViewModel viewModel)
            : base(viewModel)
        {
            InitializeComponent();
        }
    }
}
