namespace Dhgms.Whipstaff.Showcase.Desktop.View
{
    using Dhgms.Whipstaff.Showcase.Desktop.ViewModel;
    using Dhgms.Whipstaff.Showcase.Desktop.ViewModel.Interface;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow(IMainWindowViewModel viewModel)
            : base(viewModel)
        {
            this.InitializeComponent();
            this.DataContext = new MainWindowViewModel();
        }
    }
}
