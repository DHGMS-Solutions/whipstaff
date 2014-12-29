namespace Dhgms.Whipstaff.Showcase.Desktop.ViewModel
{
    using System;
    using System.Reactive;
    using System.Threading.Tasks;

    using Dhgms.Whipstaff.Core.ViewModels;

    using ReactiveUI;

    public class SplashScreenViewModel : ViewModelBase<SplashScreenViewModel>
    {
        private string _statusMessage;

        private bool _dialogResult;

        private readonly Action _programInitialisationAction;

        public SplashScreenViewModel(Action programInitialisationAction)
        {
            if (programInitialisationAction == null)
            {
                throw new ArgumentNullException("programInitialisationAction");
            }

            this._programInitialisationAction = programInitialisationAction;

            Version = System.Reflection.Assembly.GetEntryAssembly().GetName().Version.ToString();
            ProgramInitialisation = ReactiveCommand.CreateAsyncTask(async _ => await TaskEx.Run(() => _programInitialisationAction()));

            CloseView = ReactiveCommand.CreateAsyncTask(OnCloseView);

            ProgramInitialisation.ThrownExceptions.Subscribe(OnThrownException);
        }

        public ReactiveCommand<Unit> CloseView { get; private set; }

        private async Task OnCloseView(object arg)
        {
            await TaskEx.Run(
                () =>
                    {
                        var success = arg as bool?;
                        this.DialogResult = success.HasValue && success.Value;
                    });
        }

        public ReactiveCommand<Unit> ProgramInitialisation { get; private set; }

        public bool DialogResult
        {
            get
            {
                return _dialogResult;
            }

            set
            {
                this.RaiseAndSetIfChanged(ref this._dialogResult, value);
            }
        }

        public string Version { get; private set; }

        public string StatusMessage
        {
            get
            {
                return _statusMessage;
            }
            set
            {
                this.RaiseAndSetIfChanged(ref this._statusMessage, value);
            }
        }

        internal void OnViewLoaded(System.Windows.RoutedEventArgs routedEventArgs)
        {
            ProgramInitialisation.ExecuteAsyncTask();
        }

        private void OnThrownException(Exception exception)
        {
            UserError.Throw("Error during program intialisation", exception);
        }
    }
}
