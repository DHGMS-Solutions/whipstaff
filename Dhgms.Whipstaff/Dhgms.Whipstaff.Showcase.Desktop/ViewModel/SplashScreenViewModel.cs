namespace Dhgms.Whipstaff.Showcase.Desktop.View
{
    using Dhgms.Whipstaff.Core.ViewModels;

    public class SplashScreenViewModel : ViewModelBase<SplashScreenViewModel>
    {
        public SplashScreenViewModel()
        {
            Version = System.Reflection.Assembly.GetEntryAssembly().GetName().Version.ToString();
        }

        public string Version { get; private set; }
    }
}
