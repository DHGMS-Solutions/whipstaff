namespace Dhgms.Whipstaff.Showcase.Desktop.View
{
    using Dhgms.Whipstaff.Showcase.Desktop.ViewModel.Interface;

    /// <summary>
    /// Interaction logic for EmployeeView.xaml
    /// </summary>
    public partial class EmployeeView
    {
        public EmployeeView(IEmployeeViewModel viewModel)
            : base(viewModel)
        {
            InitializeComponent();
        }
    }
}
