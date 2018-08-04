namespace Dhgms.Whipstaff.Showcase.Desktop.View
{
    using System.Windows.Controls;

    using Dhgms.Whipstaff.Showcase.Desktop.Services;
    using Dhgms.Whipstaff.Showcase.Desktop.ViewModel;
    using Dhgms.Whipstaff.Showcase.Desktop.ViewModel.Interface;

    using ReactiveUI;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow(IMainWindowViewModel viewModel)
            : base(viewModel)
        {
            this.InitializeComponent();

            this.OneWayBind(this.ViewModel, vm => vm.CrossPlatformSampleCollection, vw => vw.CrossPlatformSamplesList.ItemsSource);
            this.OneWayBind(this.ViewModel, vm => vm.NativeSampleCollection, vw => vw.DesktopPlatformSamplesList.ItemsSource);
        }
    }
}
