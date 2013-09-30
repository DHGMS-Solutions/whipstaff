using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.Whipstaff.ViewModel
{
    using ReactiveUI;
    using System.Windows.Input;

    public interface IMainRibbonWindowViewModel : Wndw.IMainWindowViewModel
    {
        ReactiveList<Model.Info.KeyboardMapping> KeyboardShortcuts { get; }

        ICommand ShowEventLogCommand { get; }

        ICommand ShowHelpCommand { get; }

        ICommand ShowKeyboardShortcutsCommand { get; }

        ICommand ShowSearchCommand { get; }

        ICommand ShowOptionsCommand { get; }
    }
}
