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
        private ReactiveCommand showSearchCommand;
        private ReactiveCommand showEventLogCommand;

        private Action<object> doSearchCallback;

        private readonly IObservable<bool> canShowKeyboardShortcutsObservable;
        private readonly IObservable<bool> canShowSearchObservable;
        private readonly IObservable<bool> canShowEventLogObservable;

        private bool userCanViewEventLog;

        public MainRibbonWindowViewModel()
        {
            canShowKeyboardShortcutsObservable = this.WhenAny(x => x.KeyboardShortcuts, CanShowKeyboardShortcuts);
            canShowSearchObservable = this.WhenAny(x => x.DoSearchCallback, CanShowSearch);
            canShowEventLogObservable = this.WhenAny(x => x.UserCanViewEventLog, CanShowEventLog);
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

        public ReactiveCommand ShowEventLogCommand
        {
            get
            {
                return EnsureCommandExists(ref this.showEventLogCommand, this.canShowEventLogObservable, this.ShowEventLog);
            }
        }

        public ReactiveCommand ShowKeyboardShortcutsCommand
        {
            get
            {
                return EnsureCommandExists(ref this.showKeyboardShortcutsCommand, this.canShowKeyboardShortcutsObservable, this.ShowKeyboardShortcuts);
            }
        }

        public ReactiveCommand ShowSearchCommand
        {
            get
            {
                return EnsureCommandExists(ref this.showSearchCommand, this.canShowKeyboardShortcutsObservable, this.DoSearchCallback);
            }
        }

        public bool UserCanViewEventLog
        {
            get
            {
                return this.userCanViewEventLog;
            }
            set
            {
                this.RaiseAndSetIfChanged(ref this.userCanViewEventLog, value);
            }
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

        private bool CanShowEventLog(IObservedChange<MainRibbonWindowViewModel, bool> observable)
        {
            return observable.Value;
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

        private void ShowKeyboardShortcuts(object obj)
        {
        }

        private void ShowEventLog(object obj)
        {
        }
    }
}
