using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.Whipstaff.Desktop.Helpers
{
    using System.Windows;

    using Dhgms.Whipstaff.Desktop.Controls;

    using PerMonitorDPI;

    public static class DesktopWindowHelper
    {
        public static void InitialiseWindow<TWindow>(TWindow window)
            where TWindow : Window, IDesktopWindow
        {
            window.PerMonitorDpiBehavior = new PerMonitorDpiBehavior(window);
        }
    }
}
