namespace Dhgms.Whipstaff.Showcase.Desktop.View
{
    using Dhgms.Whipstaff.Showcase.Desktop.ViewModel.Interface;

    /// <summary>
    /// Interaction logic for ThemeSelector.xaml
    /// </summary>
    public partial class ThemeSelector
    {
        public ThemeSelector(IThemeSelectorViewModel viewModel)
            : base(viewModel)
        {
            InitializeComponent();
        }
    }
}
