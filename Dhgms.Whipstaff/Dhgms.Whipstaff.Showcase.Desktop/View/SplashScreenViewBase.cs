namespace Dhgms.Whipstaff.Showcase.Desktop.View
{
    using Dhgms.Whipstaff.Desktop.Controls;
    using Dhgms.Whipstaff.Showcase.Desktop.ViewModel;

    public class SplashScreenViewBase : WhipstaffMetroWindow<SplashScreenViewBase, SplashScreenViewModel>
    {
        public SplashScreenViewBase(SplashScreenViewModel viewModel)
            : base(viewModel)
        {
        }
    }
}
