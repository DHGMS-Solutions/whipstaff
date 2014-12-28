namespace Dhgms.Whipstaff.Showcase.Desktop.View
{
    using Dhgms.Whipstaff.Showcase.Desktop.ViewModel.Interface;

    /// <summary>
    /// Interaction logic for TicketView.xaml
    /// </summary>
    public partial class TicketView
    {
        public TicketView(ITicketViewModel viewModel)
            : base(viewModel)
        {
            InitializeComponent();
        }
    }
}
