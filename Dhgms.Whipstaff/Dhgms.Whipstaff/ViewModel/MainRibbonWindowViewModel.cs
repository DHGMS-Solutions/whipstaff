using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.Whipstaff.ViewModel
{
    using ReactiveUI;
    using System.Windows.Controls;
    using System.Windows.Input;
    using Model.Helper;

    public class MainRibbonWindowViewModel : Wndw.MainWindowViewModel, ViewModel.IMainRibbonWindowViewModel
    {
        private ReactiveList<Model.Info.KeyboardMapping> keyboardShortcuts;
        private ReactiveCommand showKeyboardShortcutsCommand;
        private ReactiveCommand showSearchCommand;
        private ReactiveCommand showOptionsCommand;
        private ReactiveCommand showEventLogCommand;
        private ReactiveCommand showHelpCommand;

        private Action<object> onShowSearchCallback;
        private Action<object> onShowHelpCallback;

        private readonly IObservable<bool> canShowKeyboardShortcutsObservable;
        private readonly IObservable<bool> canShowSearchObservable;
        private readonly IObservable<bool> canShowHelpObservable;

        public MainRibbonWindowViewModel()
        {
            canShowKeyboardShortcutsObservable = this.WhenAny(x => x.KeyboardShortcuts, CanShowKeyboardShortcuts);
            canShowSearchObservable = this.WhenAny(x => x.OnShowSearchCallback, CanShowSearch);
            canShowHelpObservable = this.WhenAny(x => x.OnShowHelpCallback, CanShowHelp);
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

        public ICommand ShowEventLogCommand
        {
            get
            {
                return ReactiveUiHelpers.EnsureCommandExists(ref this.showEventLogCommand, null, this.OnShowEventLog);
            }
        }

        public ICommand ShowHelpCommand
        {
            get
            {
                return ReactiveUiHelpers.EnsureCommandExists(ref this.showHelpCommand, this.canShowHelpObservable, this.OnShowHelp);
            }
        }

        public ICommand ShowKeyboardShortcutsCommand
        {
            get
            {
                return ReactiveUiHelpers.EnsureCommandExists(ref this.showKeyboardShortcutsCommand, this.canShowKeyboardShortcutsObservable, this.OnShowKeyboardShortcuts);
            }
        }

        public ICommand ShowSearchCommand
        {
            get
            {
                return ReactiveUiHelpers.EnsureCommandExists(ref this.showSearchCommand, this.canShowKeyboardShortcutsObservable, this.OnShowSearch);
            }
        }

        public ICommand ShowOptionsCommand
        {
            get
            {
                return ReactiveUiHelpers.EnsureCommandExists(ref this.showOptionsCommand, null, this.OnShowOptions);
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

        private bool CanShowHelp(IObservedChange<MainRibbonWindowViewModel, Action<object>> helpCallbackObservable)
        {
            return helpCallbackObservable.Value != null;
        }

        public Action<object> OnShowHelpCallback
        {
            get
            {
                return this.onShowHelpCallback;
            }
            set
            {
                this.RaiseAndSetIfChanged(ref this.onShowHelpCallback, value);
            }
        }

        public Action<object> OnShowSearchCallback
        {
            get
            {
                return this.onShowSearchCallback;
            }
            set
            {
                this.RaiseAndSetIfChanged(ref this.onShowSearchCallback, value);
            }
        }

        private void OnShowKeyboardShortcuts(object obj)
        {
        }

        private void OnShowHelp(object obj)
        {
            if (this.OnShowHelpCallback == null)
            {
                throw new InvalidOperationException("OnShowHelpCallback is not set");
            }

            this.OnShowHelp(obj);
        }

        private void OnShowEventLog(object obj)
        {
        }

        private void OnShowSearch(object obj)
        {
            if (this.OnShowSearchCallback == null)
            {
                throw new InvalidOperationException("OnShowSearchCallback is not set");
            }

            this.OnShowSearchCallback(obj);
        }

        private void OnShowOptions(object obj)
        {
        }
    }
}
