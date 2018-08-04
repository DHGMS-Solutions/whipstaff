namespace Dhgms.Whipstaff.ViewModel.Ctrl
{
    using ReactiveUI;
    using System;
    using System.Windows.Threading;

    public class SingleLineTextInputControlViewModel : Dhgms.Whipstaff.ViewModel.ViewModelBase<SingleLineTextInputControlViewModel>, ISingleLineTextInputControlViewModel
    {
        private readonly DispatcherTimer validationTimer;

        private string actualValue;
        private int maximumLength;
        private string title;
        private string description;
        private bool required;
        private readonly ObservableAsPropertyHelper<int> remainingCharacters;

        private readonly ObservableAsPropertyHelper<Dhgms.Whipstaff.Model.Info.ValidationDetails> validationDetails;
        private string watermark;

        private Func<string, Dhgms.Whipstaff.Model.Info.ValidationDetails> validationMethod;

        public SingleLineTextInputControlViewModel()
        {
            this.validationTimer = new DispatcherTimer();

            this.remainingCharacters = this.WhenAny(x => x.ActualValue, x => x.MaximumLength, GetRemainingCharacters).ToProperty(this, x => x.RemainingCharacters);

            this.validationDetails = this.WhenAny(x => x.ActualValue, x => x.Required, x => x.ValidationMethod, GetValidationDetails).ToProperty(this, x => x.ValidationDetails);
        }

        public string Title
        {
            get
            {
                return this.title;
            }

            set
            {
                this.RaiseAndSetIfChanged(ref this.title, value);
            }
        }

        public string Description
        {
            get
            {
                return this.description;
            }

            set
            {
                this.RaiseAndSetIfChanged(ref this.description, value);
            }
        }

        public int RemainingCharacters
        {
            get
            {
                return this.remainingCharacters.Value;
            }
        }

        public string ActualValue
        {
            get
            {
                return this.actualValue;
            }

            set
            {
                this.RaiseAndSetIfChanged(ref this.actualValue, value);
            }
        }

        public bool Required
        {
            get
            {
                return this.required;
            }

            set
            {
                this.RaiseAndSetIfChanged(ref this.required, value);
            }
        }

        public int MaximumLength
        {
            get
            {
                return this.maximumLength;
            }

            set
            {
                this.RaiseAndSetIfChanged(ref this.maximumLength, value);
            }
        }

        public Dhgms.Whipstaff.Model.Info.ValidationDetails ValidationDetails
        {
            get
            {
                return this.validationDetails.Value;
            }
        }

        public string Watermark
        {
            get
            {
                return this.watermark;
            }

            set
            {
                this.RaiseAndSetIfChanged(ref this.watermark, value);
            }
        }

        public Func<string, Dhgms.Whipstaff.Model.Info.ValidationDetails> ValidationMethod
        {
            get
            {
                return this.validationMethod;
            }
            set
            {
                this.RaiseAndSetIfChanged(ref this.validationMethod, value);
            }
        }

        private Dhgms.Whipstaff.Model.Info.ValidationDetails GetValidationDetails(IObservedChange<SingleLineTextInputControlViewModel, string> val, IObservedChange<SingleLineTextInputControlViewModel, bool> req, IObservedChange<SingleLineTextInputControlViewModel, Func<string, Dhgms.Whipstaff.Model.Info.ValidationDetails>> validatorObservable)
        {
            // cancel any pending deferred validation
            if (this.validationTimer.IsEnabled)
            {
                this.validationTimer.Stop();
            }

            var val1 = val.Value;
            var req1 = req.Value;
            if (string.IsNullOrWhiteSpace(val1) || val1.Length == 0)
            {
                return req1 ? new Model.Info.ValidationDetails(Dhgms.Whipstaff.Model.Info.ValidationIndicator.Required, "Requested")
                    : new Model.Info.ValidationDetails(Dhgms.Whipstaff.Model.Info.ValidationIndicator.Optional, "Optional");
            }

            if (this.ValidationMethod != null)
            {
                //validation to be deferred, handy if we want to wait till user stops typing, rather than do per char
                this.validationTimer.Start();
                return new Model.Info.ValidationDetails(Dhgms.Whipstaff.Model.Info.ValidationIndicator.InProgress, "Pending");
            }

            return new Model.Info.ValidationDetails(Dhgms.Whipstaff.Model.Info.ValidationIndicator.Ok, string.Empty);
        }

        private static int GetRemainingCharacters(IObservedChange<SingleLineTextInputControlViewModel, string> val, IObservedChange<SingleLineTextInputControlViewModel, int> max)
        {
            var val1 = val.Value;
            var max1 = max.Value;
            return string.IsNullOrWhiteSpace(val1) ? max1 : max1 - val1.Length;
        }

        private void ValidationTimerTick(object state, EventArgs e)
        {
            //HACK: this looks a bit dirty, is there a better way?
            //TODO: use an Rx style throttle instead
            var subject = new ScheduledSubject<Dhgms.Whipstaff.Model.Info.ValidationDetails>(RxApp.MainThreadScheduler);
            subject.ToProperty(this, x=> x.ValidationDetails);
            var vf = this.ValidationMethod(this.ActualValue);
            subject.OnNext(vf);
        }
    }
}
