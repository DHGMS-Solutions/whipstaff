namespace Dhgms.Whipstaff.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using ReactiveUI;
    using System.Windows.Controls;
    using System.Windows.Input;
    using Model.Helper;

    public class MainRibbonWindowViewModel : Wndw.MainWindowViewModel, ViewModel.IMainRibbonWindowViewModel
    {
        private ReactiveList<Model.Info.KeyboardMapping> keyboardShortcuts;

        // Commands
        private ReactiveCommand<object> showEventLogCommand;
        private ReactiveCommand<object> showFeedbackCommand;
        private ReactiveCommand<object> showHelpCommand;
        private ReactiveCommand<object> showKeyboardShortcutsCommand;
        private ReactiveCommand<object> showNotificationsCommand;
        private ReactiveCommand<object> showOptionsCommand;
        private ReactiveCommand<object> showSearchCommand;

        // Callbacks
        private Action<object> onShowEventLogCallback;
        private Action<object> onShowFeedbackCallback;
        private Action<object> onShowHelpCallback;
        private Action<object> onShowKeyboardShortcutsCallback;
        private Action<object> onShowNotificationsCallback;
        private Action<object> onShowOptionsCallback;
        private Action<object> onShowSearchCallback;

        // Observables
        private readonly IObservable<bool> canShowEventLogObservable;
        private readonly IObservable<bool> canShowFeedbackObservable;
        private readonly IObservable<bool> canShowHelpObservable;
        private readonly IObservable<bool> canShowKeyboardShortcutsObservable;
        private readonly IObservable<bool> canShowNotificationsObservable;
        private readonly IObservable<bool> canShowOptionsObservable;
        private readonly IObservable<bool> canShowSearchObservable;

        // Observable Property Helper
        private readonly ObservableAsPropertyHelper<bool> canShowEventLogPropertyHelper;
        private readonly ObservableAsPropertyHelper<bool> canShowFeedbackPropertyHelper;
        private readonly ObservableAsPropertyHelper<bool> canShowHelpPropertyHelper;
        private readonly ObservableAsPropertyHelper<bool> canShowKeyboardShortcutsPropertyHelper;
        private readonly ObservableAsPropertyHelper<bool> canShowNotificationsPropertyHelper;
        private readonly ObservableAsPropertyHelper<bool> canShowOptionsPropertyHelper;
        private readonly ObservableAsPropertyHelper<bool> canShowSearchPropertyHelper;

        public MainRibbonWindowViewModel()
        {
            /*
            this.InitializeObservableAndPropertyHelper(
                this.WhenAny(x => x.OnShowEventLogCallback, HasCallbackAssigned),
                x => x.CanShowEventLog,
                ref this.canShowEventLogObservable,
                ref this.canShowEventLogPropertyHelper);

            this.InitializeObservableAndPropertyHelper(
                this.WhenAny(x => x.OnShowHelpCallback, HasCallbackAssigned),
                x => x.CanShowHelp,
                ref this.canShowHelpObservable,
                ref this.canShowHelpPropertyHelper);

            this.InitializeObservableAndPropertyHelper(
                this.WhenAny(x => x.KeyboardShortcuts, x => x.OnShowKeyboardShortcutsCallback, CheckCanShowKeyboardShortcuts),
                x => x.CanShowKeyboardShortcuts,
                ref this.canShowKeyboardShortcutsObservable,
                ref this.canShowKeyboardShortcutsPropertyHelper);

            this.InitializeObservableAndPropertyHelper(
                this.WhenAny(x => x.OnShowOptionsCallback, HasCallbackAssigned),
                x => x.CanShowOptions,
                ref this.canShowOptionsObservable,
                ref this.canShowOptionsPropertyHelper);

            this.InitializeObservableAndPropertyHelper(
                this.WhenAny(x => x.OnShowSearchCallback, HasCallbackAssigned),
                x => x.CanShowSearch,
                ref this.canShowSearchObservable,
                ref this.canShowSearchPropertyHelper);
             * */

            this.canShowEventLogObservable = this.WhenAny(x => x.OnShowEventLogCallback, HasCallbackAssigned);
            this.canShowEventLogPropertyHelper = this.canShowEventLogObservable.ToProperty(this, x => x.CanShowEventLog);

            this.canShowFeedbackObservable = this.WhenAny(x => x.OnShowFeedbackCallback, HasCallbackAssigned);
            this.canShowFeedbackPropertyHelper = this.canShowFeedbackObservable.ToProperty(this, x => x.CanShowFeedback);

            this.canShowHelpObservable = this.WhenAny(x => x.OnShowHelpCallback, HasCallbackAssigned);
            this.canShowHelpPropertyHelper = this.canShowHelpObservable.ToProperty(this, x => x.CanShowHelp);

            this.canShowKeyboardShortcutsObservable = this.WhenAny(x => x.KeyboardShortcuts, x => x.OnShowKeyboardShortcutsCallback, CheckCanShowKeyboardShortcuts);
            this.canShowKeyboardShortcutsPropertyHelper = this.canShowKeyboardShortcutsObservable.ToProperty(this, x => x.CanShowKeyboardShortcuts);

            this.canShowNotificationsObservable = this.WhenAny(x => x.OnShowNotificationsCallback, HasCallbackAssigned);
            this.canShowNotificationsPropertyHelper = this.canShowNotificationsObservable.ToProperty(this, x => x.CanShowNotifications);

            this.canShowOptionsObservable = this.WhenAny(x => x.OnShowOptionsCallback, HasCallbackAssigned);
            this.canShowOptionsPropertyHelper = this.canShowOptionsObservable.ToProperty(this, x => x.CanShowOptions);

            this.canShowSearchObservable = this.WhenAny(x => x.OnShowSearchCallback, HasCallbackAssigned);
            this.canShowSearchPropertyHelper = this.canShowSearchObservable.ToProperty(this, x => x.CanShowSearch);
        }

        /*
        private void InitializeObservableAndPropertyHelper(
            IObservable<bool> whenAnyObservable,
            System.Linq.Expressions.Expression<Func<MainRibbonWindowViewModel, bool>> propertyHelperExpression,
            ref IObservable<bool> observableBackingField,
            ref ObservableAsPropertyHelper<bool> observableAsPropertyHelper)
        {
            observableBackingField = whenAnyObservable;
            observableAsPropertyHelper = observableBackingField.ToProperty(this, propertyHelperExpression);
        }
         * */

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
                return ReactiveUiHelpers.EnsureCommandExists(ref this.showEventLogCommand, this.canShowEventLogObservable, this.OnShowEventLog);
            }
        }

        public ICommand ShowFeedbackCommand
        {
            get
            {
                return ReactiveUiHelpers.EnsureCommandExists(ref this.showFeedbackCommand, this.canShowFeedbackObservable, this.OnShowFeedback);
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

        public ICommand ShowNotificationCommand
        {
            get
            {
                return ReactiveUiHelpers.EnsureCommandExists(ref this.showNotificationsCommand, this.canShowNotificationsObservable, this.OnShowNotifications);
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
                return ReactiveUiHelpers.EnsureCommandExists(ref this.showOptionsCommand, this.canShowOptionsObservable, this.OnShowOptions);
            }
        }

        public bool CanShowKeyboardShortcuts
        {
            get
            {
                return this.canShowKeyboardShortcutsPropertyHelper.Value;
            }
        }

        public bool CanShowEventLog
        {
            get
            {
                return this.canShowEventLogPropertyHelper.Value;
            }
        }

        public bool CanShowFeedback
        {
            get
            {
                return this.canShowFeedbackPropertyHelper.Value;
            }
        }

        public bool CanShowNotifications
        {
            get
            {
                return this.canShowNotificationsPropertyHelper.Value;
            }
        }

        public bool CanShowSearch
        {
            get
            {
                return this.canShowSearchPropertyHelper.Value;
            }
        }

        public bool CanShowOptions
        {
            get
            {
                return this.canShowOptionsPropertyHelper.Value;
            }
        }

        public bool CanShowHelp
        {
            get
            {
                return this.canShowHelpPropertyHelper.Value;
            }
        }

        public int NotificationCount
        {
            get
            {
                return 0;
            }
        }

        public bool CheckCanShowKeyboardShortcuts(IObservedChange<MainRibbonWindowViewModel, ReactiveList<Model.Info.KeyboardMapping>> collectionObservable, IObservedChange<MainRibbonWindowViewModel, Action<object>> callbackObservable)
        {
            return HasCallbackAssigned(callbackObservable) && collectionObservable.Value != null && collectionObservable.Value.Count > 0;
        }

        private bool HasCallbackAssigned(IObservedChange<MainRibbonWindowViewModel, Action<object>> observable)
        {
            return observable.Value != null;
        }

        public Action<object> OnShowEventLogCallback
        {
            get
            {
                return this.onShowEventLogCallback;
            }
            set
            {
                this.RaiseAndSetIfChanged(ref this.onShowEventLogCallback, value);
            }
        }

        public Action<object> OnShowFeedbackCallback
        {
            get
            {
                return this.onShowFeedbackCallback;
            }
            set
            {
                this.RaiseAndSetIfChanged(ref this.onShowFeedbackCallback, value);
            }
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

        public Action<object> OnShowKeyboardShortcutsCallback
        {
            get
            {
                return this.onShowKeyboardShortcutsCallback;
            }
            set
            {
                this.RaiseAndSetIfChanged(ref this.onShowKeyboardShortcutsCallback, value);
            }
        }

        public Action<object> OnShowNotificationsCallback
        {
            get
            {
                return this.onShowNotificationsCallback;
            }
            set
            {
                this.RaiseAndSetIfChanged(ref this.onShowNotificationsCallback, value);
            }
        }

        public Action<object> OnShowOptionsCallback
        {
            get
            {
                return this.onShowOptionsCallback;
            }
            set
            {
                this.RaiseAndSetIfChanged(ref this.onShowOptionsCallback, value);
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

        private void OnShowEventLog(object obj)
        {
            OnCallback(this.OnShowSearchCallback, obj, "OnShowSearch");
        }

        private void OnShowFeedback(object obj)
        {
            OnCallback(this.OnShowFeedbackCallback, obj, "OnShowFeedback");
        }

        private void OnShowHelp(object obj)
        {
            OnCallback(this.OnShowHelpCallback, obj, "OnShowHelp");
        }

        private void OnShowKeyboardShortcuts(object obj)
        {
            OnCallback(this.OnShowKeyboardShortcutsCallback, obj, "OnShowKeyboardShortcuts");
        }

        private void OnShowNotifications(object obj)
        {
            OnCallback(this.OnShowNotificationsCallback, obj, "OnShowNotifications");
        }

        private void OnShowSearch(object obj)
        {
            OnCallback(this.OnShowSearchCallback, obj, "OnShowSearch");
        }

        private void OnShowOptions(object obj)
        {
            OnCallback(this.OnShowOptionsCallback, obj, "OnShowOptions");
        }

        private static void OnCallback(Action<object> action, object obj, string p)
        {
            if (action == null)
            {
                throw new InvalidOperationException(p + " Callback is not set");
            }

            action(obj);
        }
    }
}
