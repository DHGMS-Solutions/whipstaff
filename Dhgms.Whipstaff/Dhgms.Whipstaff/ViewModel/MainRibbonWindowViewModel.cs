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
        private ReactiveCommand showKeyboardShortcutsCommand;
        private Action<object> doSearchCallback;

        private readonly IObservable<bool> canShowKeyboardShortcutsObservable;
        private readonly IObservable<bool> canShowSearchObservable;
        private readonly IObservable<bool> canExecuteQueryPaymentSessionStatusObservable;

        public MainRibbonWindowViewModel()
        {
            canShowKeyboardShortcutsObservable = this.WhenAny(x => x.KeyboardShortcuts, CanShowKeyboardShortcuts);
            canShowSearchObservable = this.WhenAny(x => x.DoSearchCallback, CanShowSearch);
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

        public ReactiveCommand ShowKeyboardShortcutsCommand
        {
            get
            {
                return EnsureCommandExists(ref this.showKeyboardShortcutsCommand, this.canExecuteQueryPaymentSessionStatusObservable, this.DoSearchCallback);
            }
        }

        public ReactiveCommand ShowSearchCommand
        {
            get;
            protected set;
        }

        private bool CanShowKeyboardShortcuts(IObservedChange<MainRibbonWindowViewModel, ReactiveList<Model.Info.KeyboardMapping>> ksObservable)
        {
            var ks = ksObservable.Value;
            return ks != null && ks.Count > 0;
        }

        private bool CanShowSearch(IObservedChange<MainRibbonWindowViewModel, Action<object>> searchCallbackObservable)
        {
            return searchCallbackObservable.Value != null;
        }

        protected Action<object> DoSearchCallback
        {
            get
            {
                return this.doSearchCallback;
            }
            set
            {
                this.RaiseAndSetIfChanged(ref this.doSearchCallback, value);
            }
        }
    }
}
