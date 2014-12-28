namespace Dhgms.Whipstaff.Showcase.Desktop.View
{
    using Dhgms.Whipstaff.Showcase.Desktop.ViewModel.Interface;

    /// <summary>
    /// Interaction logic for TicketListView.xaml
    /// </summary>
    public partial class TicketListView
    {
        public TicketListView(ITicketListViewModel viewModel)
            : base(viewModel)
        {
            InitializeComponent();
        }
    }
}
