namespace Dhgms.Whipstaff.Showcase.Desktop.ViewModel
{
    using System.Collections.Generic;

    using Dhgms.Whipstaff.Showcase.Desktop.ViewModel.Interface;

    using ReactiveUI;

    public class ThemeSelectorViewModel : ReactiveObject, IThemeSelectorViewModel, IRoutableViewModel
    {
        public string UrlPathSegment
        {
            get
            {
                return "ThemeSelector";
            }
        }

        public IScreen HostScreen { get; protected set; }

        public List<string> Themes { get; set; }
    }
}
