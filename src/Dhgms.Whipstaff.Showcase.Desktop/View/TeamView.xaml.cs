namespace Dhgms.Whipstaff.Showcase.Desktop.View
{
    using Dhgms.Whipstaff.Showcase.Desktop.ViewModel.Interface;

    /// <summary>
    /// Interaction logic for TeamView.xaml
    /// </summary>
    public partial class TeamView
    {
        public TeamView(ITeamViewModel viewModel)
            : base(viewModel)
        {
            InitializeComponent();
        }
    }
}
