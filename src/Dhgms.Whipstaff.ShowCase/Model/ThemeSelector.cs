using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using Dhgms.Whipstaff.ShowCase.Model.Info;

namespace Dhgms.Whipstaff.ShowCase.Model
{
    public class ThemeSelector
    {
        public ViewModel.ThemeSelectorViewModel CreateViewModel()
        {
            /*
            var result = new ViewModel.ThemeSelectorViewModel {Themes = new Dictionary<string, PaletteValues>()};

            foreach (var theme in ((App)App.Current).Themes)
            {
                var val1 = theme.Value["PaletteColor1"] as SolidColorBrush;
                var val2 = theme.Value["PaletteColor2"] as SolidColorBrush;
                var val3 = theme.Value["PaletteColor3"] as SolidColorBrush;
                var val4 = theme.Value["PaletteColor4"] as SolidColorBrush;
                var val5 = theme.Value["PaletteColor5"] as SolidColorBrush;

                var pv = new PaletteValues
                             {
                                 First = val1.Color,
                                 Second = val2.Color,
                                 Third = val3.Color,
                                 Fourth = val4.Color,
                                 Fifth = val5.Color,
                             };
                result.Themes.Add(theme.Key, pv);
            }
             * */

            return null;
        }
    }
}
