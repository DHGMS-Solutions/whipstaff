using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.Whipstaff.Desktop.Controls
{
    using Dhgms.Whipstaff.Desktop.Helpers;

    using MahApps.Metro.Controls;

    using PerMonitorDPI;

    public class WhipstaffMetroWindow : MetroWindow, IDesktopWindow
    {
        public WhipstaffMetroWindow()
        {
            DesktopWindowHelper.InitialiseWindow(this);
        }

        public PerMonitorDpiBehavior PerMonitorDpiBehavior { get; set; }
    }
}
