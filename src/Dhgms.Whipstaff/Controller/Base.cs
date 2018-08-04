using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.Whipstaff.Controller
{
    public abstract class Base : System.Windows.Application
    {
        public abstract ViewModel.MainRibbonWindowViewModel MainWindowViewModel
        {
            get;
        }
    }
}
