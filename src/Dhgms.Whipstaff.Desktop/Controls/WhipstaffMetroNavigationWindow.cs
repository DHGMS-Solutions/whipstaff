namespace Dhgms.Whipstaff.Desktop.Controls
{
    using Dhgms.Whipstaff.Desktop.Helpers;

    using MahApps.Metro.Controls;

    using PerMonitorDPI;

    public class WhipstaffMetroNavigationWindow : MetroNavigationWindow, IDesktopWindow
    {
        public WhipstaffMetroNavigationWindow()
        {
            DesktopWindowHelper.InitialiseWindow(this);
        }

        public PerMonitorDpiBehavior PerMonitorDpiBehavior { get; set; }
    }
}
