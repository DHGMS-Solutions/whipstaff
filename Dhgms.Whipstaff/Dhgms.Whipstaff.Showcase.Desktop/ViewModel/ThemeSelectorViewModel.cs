using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dhgms.Whipstaff.ShowCase.ViewModel
{
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
