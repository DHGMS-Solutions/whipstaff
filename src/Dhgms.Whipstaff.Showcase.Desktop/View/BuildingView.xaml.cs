namespace Dhgms.Whipstaff.Showcase.Desktop.View
{
    using Dhgms.Whipstaff.Showcase.Desktop.ViewModel.Interface;

    /// <summary>
    /// Interaction logic for BuildingView.xaml
    /// </summary>
    public partial class BuildingView
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingView"/> class.
        /// </summary>
        public BuildingView(IBuildingViewModel viewModel)
            : base(viewModel)
        {
            InitializeComponent();
        }
    }
}
