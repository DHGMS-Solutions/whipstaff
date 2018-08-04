using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace Dhgms.Whipstaff.ShowCase
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        public readonly Dictionary<string, ResourceDictionary> Themes;

        public App()
        {
            Themes = new Dictionary<string, ResourceDictionary>
            {
                {"Blues", GetResourceDictionary("Blues.xaml")},
                {"BuGn", GetResourceDictionary("BuGn.xaml")},
                {"BuPu", GetResourceDictionary("BuPu.xaml")},
                {"GnBu", GetResourceDictionary("GnBu.xaml")},
                {"Greens", GetResourceDictionary("Greens.xaml")},
                {"Greys", GetResourceDictionary("Greys.xaml")},
                {"Oranges", GetResourceDictionary("Oranges.xaml")},
                {"OrRd", GetResourceDictionary("OrRd.xaml")},
                {"PuBu", GetResourceDictionary("PuBu.xaml")},
                {"PuBuGn", GetResourceDictionary("PuBuGn.xaml")},
                {"PuRd", GetResourceDictionary("PuRd.xaml")},
                {"Purples", GetResourceDictionary("Purples.xaml")},
                {"RdPu", GetResourceDictionary("RdPu.xaml")},
                {"Reds", GetResourceDictionary("Reds.xaml")},
                {"YlGn", GetResourceDictionary("YlGn.xaml")},
                {"YlGnBu", GetResourceDictionary("YlGnBu.xaml")},
                {"YlOrBr", GetResourceDictionary("YlOrBr.xaml")},
                {"YlOrRd", GetResourceDictionary("YlOrRd.xaml")},
            };
        }

        private string _currentTheme;

        public string CurrentTheme
        {
            get { return _currentTheme; }
            set { _currentTheme = value; }
        }

        public void ChangeTheme(string theme)
        {
            if (theme != _currentTheme)
            {
                var item = Themes.First(pair => pair.Key == theme);
                _currentTheme = theme;
                this.Resources.MergedDictionaries.Clear();
                this.Resources.MergedDictionaries.Add(item.Value);
            }
        }

        ResourceDictionary GetResourceDictionary(string source)
        {
            return Application.LoadComponent(new Uri("/Assets/" + source, UriKind.Relative)) as ResourceDictionary;
        }
    }
}
