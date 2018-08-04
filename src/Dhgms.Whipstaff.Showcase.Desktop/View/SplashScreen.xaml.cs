namespace Dhgms.Whipstaff.Showcase.Desktop.View
{
    using System;
    using System.Reactive.Linq;
    using System.Threading.Tasks;
    using System.Windows;

    using Dhgms.Whipstaff.Showcase.Desktop.ViewModel;

    using MahApps.Metro.Controls.Dialogs;

    using ReactiveUI;

    /// <summary>
    /// Interaction logic for SplashScreen.xaml
    /// </summary>
    public partial class SplashScreen
    {
        private IDisposable _errorHandler;

        public SplashScreen(SplashScreenViewModel viewModel)
            : base(viewModel)
        {
            InitializeComponent();

            this.Bind(this.ViewModel, vm => vm.Version, vw => vw.Version.Content);
            this.Bind(this.ViewModel, vm => vm.StatusMessage, vw => vw.StatusMessage.Content);

            this.Events().Loaded.Subscribe(viewModel.OnViewLoaded);

            this._errorHandler = UserError.RegisterHandler(async error =>
                    {
                        await this.ShowMessageAsync("Error", error.ErrorMessage);

                        await this.ViewModel.CloseView.ExecuteAsyncTask(false);

                        return await Observable.Return(RecoveryOptionResult.FailOperation);
                    });


            this.ViewModel.CloseView.Subscribe(
                _ =>
                    {
                        _errorHandler.Dispose();
                        _errorHandler = null;
                        this.Close();
                    });
        }
    }
}