namespace Dhgms.Whipstaff.Showcase.Desktop.View
{
    using Dhgms.Whipstaff.Showcase.Desktop.ViewModel.Interface;

    /// <summary>
    /// Interaction logic for DepartmentView.xaml
    /// </summary>
    public partial class DepartmentView
    {
        public DepartmentView(IDepartmentViewModel viewModel)
            : base(viewModel)
        {
            InitializeComponent();
        }
    }
}
