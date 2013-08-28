using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.Whipstaff.ViewModel
{
    using ReactiveUI;
    using System.Windows.Controls;

    public class MainRibbonWindowViewModel : Wndw.MainWindowViewModel, ViewModel.IMainRibbonWindowViewModel
    {
        private ReactiveList<Model.Info.KeyboardMapping> keyboardShortcuts;

        public MainRibbonWindowViewModel()
        {
            var canShowKeyboardShortcutsObservable = this.WhenAny(x => x.KeyboardShortcuts, CanShowKeyboardShortcuts);
            this.ShowKeyboardShortcuts = new ReactiveCommand(canShowKeyboardShortcutsObservable);
        }

        public ReactiveList<Model.Info.KeyboardMapping> KeyboardShortcuts
        {
            get
            {
                return this.keyboardShortcuts;
            }
            set
            {
                this.RaiseAndSetIfChanged(ref this.keyboardShortcuts, value);
            }
        }

        public ReactiveCommand ShowKeyboardShortcuts
        {
            get;
            protected set;
        }

        private bool CanShowKeyboardShortcuts(IObservedChange<MainRibbonWindowViewModel, ReactiveList<Model.Info.KeyboardMapping>> ksObservable)
        {
            var ks = ksObservable.Value;
            return ks != null && ks.Count > 0;
        }
    }
}
