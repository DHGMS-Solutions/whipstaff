namespace Dhgms.Whipstaff.ViewModel.Ctrl
{
    using ReactiveUI;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SingleLineTextInputControlViewModel : Dhgms.Whipstaff.ViewModel.Base, ISingleLineTextInputControlViewModel
    {
        private string actualValue;
        private int maximumLength;
        private string title;
        private string description;
        private bool required;
        private ObservableAsPropertyHelper<int> remainingCharacters;
        private ObservableAsPropertyHelper<Dhgms.Whipstaff.Model.Info.ValidationIndicator> validationIndicator;
        private ObservableAsPropertyHelper<string> validationFeedback;
        private string watermark;

        public SingleLineTextInputControlViewModel()
        {
            this.remainingCharacters = this.WhenAny(x => x.ActualValue, x => x.MaximumLength, GetRemainingCharacters).ToProperty(this, x => x.RemainingCharacters);

            this.validationIndicator = this.WhenAny(x => x.ActualValue, x => x.Required, GetValidationIndicator).ToProperty(this, x => x.ValidationIndicator);

            this.validationFeedback = this.WhenAny(x => x.ActualValue, x => x.Required, GetValidationFeedback).ToProperty(this, x => x.ValidationFeedback);
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

        public string ValidationFeedback
        {
            get
            {
                return this.validationFeedback.Value;
            }
        }

        public Dhgms.Whipstaff.Model.Info.ValidationIndicator ValidationIndicator
        {
            get
            {
                return this.validationIndicator.Value;
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

        private static string GetValidationFeedback(IObservedChange<SingleLineTextInputControlViewModel, string> val, IObservedChange<SingleLineTextInputControlViewModel, bool> req)
        {
            //var val1 = val.Value;
            //var req1 = req.Value;

            //TODO: allow registration of additional validators

            return string.Empty;
        }

        private static Dhgms.Whipstaff.Model.Info.ValidationIndicator GetValidationIndicator(IObservedChange<SingleLineTextInputControlViewModel, string> val, IObservedChange<SingleLineTextInputControlViewModel, bool> req)
        {
            var val1 = val.Value;
            var req1 = req.Value;
            if (string.IsNullOrWhiteSpace(val1) || val1.Length == 0)
            {
                return req1 ? Dhgms.Whipstaff.Model.Info.ValidationIndicator.Required : Dhgms.Whipstaff.Model.Info.ValidationIndicator.Optional;
            }

            //TODO: allow registration of additional validators

            return Dhgms.Whipstaff.Model.Info.ValidationIndicator.Ok;
        }

        private static int GetRemainingCharacters(IObservedChange<SingleLineTextInputControlViewModel, string> val, IObservedChange<SingleLineTextInputControlViewModel, int> max)
        {
            var val1 = val.Value;
            var max1 = max.Value;
            return string.IsNullOrWhiteSpace(val1) ? max1 : max1 - val1.Length;
        }
    }
}
