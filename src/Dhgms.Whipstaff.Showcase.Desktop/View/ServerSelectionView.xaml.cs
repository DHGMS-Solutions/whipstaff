namespace Dhgms.Whipstaff.Showcase.Desktop.View
{
    using Dhgms.Whipstaff.Showcase.Desktop.ViewModel.Interface;

    /// <summary>
    /// Interaction logic for ServerSelectionView.xaml
    /// </summary>
    public partial class ServerSelectionView
    {
        public ServerSelectionView(IServerSelectionViewModel viewModel)
            : base(viewModel)
        {
            InitializeComponent();
        }
    }
}
