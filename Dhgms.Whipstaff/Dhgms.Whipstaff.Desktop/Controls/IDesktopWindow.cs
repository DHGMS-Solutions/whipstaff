using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.Whipstaff.Desktop.Controls
{
    using PerMonitorDPI;

    public interface IDesktopWindow
    {
        PerMonitorDpiBehavior PerMonitorDpiBehavior { get; set; }
    }
}
