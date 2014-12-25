namespace Dhgms.Whipstaff.Showcase.Desktop.View
{
    using Dhgms.Whipstaff.Showcase.Desktop.ViewModel.Interface;

    /// <summary>
    /// Interaction logic for DeskViewModel.xaml
    /// </summary>
    public partial class DeskViewModel
    {
        public DeskViewModel(IDeskViewModel viewModel)
            : base(viewModel)
        {
            InitializeComponent();
        }
    }
}
