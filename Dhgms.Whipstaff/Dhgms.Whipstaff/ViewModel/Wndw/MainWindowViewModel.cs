using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Dhgms.Whipstaff.ViewModel.Wndw
{
    using ReactiveUI;

    public class MainWindowViewModel : Dhgms.Whipstaff.ViewModel.Base<MainWindowViewModel>, IMainWindowViewModel
    {
        private UserControl mainControl;

        public UserControl MainControl
        {
            get
            {
                return this.mainControl;
            }
            set
            {
                this.RaiseAndSetIfChanged(ref this.mainControl, value);
            }
        }
    }
}
