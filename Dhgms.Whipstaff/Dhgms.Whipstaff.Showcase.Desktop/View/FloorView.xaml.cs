namespace Dhgms.Whipstaff.Showcase.Desktop.View
{
    using Dhgms.Whipstaff.Showcase.Desktop.ViewModel.Interface;

    /// <summary>
    /// Interaction logic for FloorView.xaml
    /// </summary>
    public partial class FloorView
    {
        public FloorView(IFloorViewModel viewModel)
            : base(viewModel)
        {
            InitializeComponent();
        }
    }
}
