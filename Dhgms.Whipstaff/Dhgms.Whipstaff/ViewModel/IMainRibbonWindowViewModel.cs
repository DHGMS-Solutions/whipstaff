using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.Whipstaff.ViewModel
{
    using ReactiveUI;

    public interface IMainRibbonWindowViewModel : Wndw.IMainWindowViewModel
    {
        ReactiveList<Model.Info.KeyboardMapping> KeyboardShortcuts { get; }

        ReactiveCommand ShowKeyboardShortcuts { get; }
    }
}
