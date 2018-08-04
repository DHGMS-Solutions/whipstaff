using System;
using System.Collections.Generic;
namespace Dhgms.Whipstaff.ViewModel.Controls
{
    using ReactiveUI;

    public class TextInputControlGroupViewModel : ReactiveObject
    {
        private int maximumLength;

        private readonly ObservableAsPropertyHelper<bool> enabledPropertyHelper;
        private readonly ObservableAsPropertyHelper<bool> isValidPropertyHelper;
        private readonly ObservableAsPropertyHelper<bool> requiredPropertyHelper;
        private readonly ObservableAsPropertyHelper<int> remainingSpacePropertyHelper;
        private readonly ObservableAsPropertyHelper<string> textValidationFailureMessagePropertyHelper;

        private string text;

        private readonly Func<string, string> extendedValidator;

        public TextInputControlGroupViewModel(
            int maxLength,
            ObservableAsPropertyHelper<bool> requiredPropertyHelper,
            string text,
            ObservableAsPropertyHelper<bool> enabledPropertyHelper,
            Func<string, string> extendedValidator = null)
        {
            if (maxLength < 0)
            {
                throw new ArgumentOutOfRangeException("maxLength");
            }

            this.enabledPropertyHelper = enabledPropertyHelper;
            this.requiredPropertyHelper = requiredPropertyHelper;

            this.textValidationFailureMessagePropertyHelper = this.WhenAny(
                vm => vm.Text,
                vm => vm.IsRequired,
                vm => vm.MaximumLength,
                GetValidationFailureMessage).ToProperty(this, vm => vm.TextValidationFailureMessage);

            this.isValidPropertyHelper = this.WhenAny(vm => vm.TextValidationFailureMessage, GetIsValidFlag).ToProperty(this, vm => vm.IsValid);
            
            this.remainingSpacePropertyHelper = this.WhenAny(vm => vm.Text, vm => vm.MaximumLength, GetRemainingSpace)
                .ToProperty(this, vm => vm.RemainingSpace);

            this.MaximumLength = maxLength;
            this.Text = text;
            this.extendedValidator = extendedValidator;
        }

        public string TextValidationFailureMessage
        {
            get
            {
                return this.textValidationFailureMessagePropertyHelper.Value;
            }
        }

        public bool Enabled
        {
            get
            {
                return this.enabledPropertyHelper.Value;
            }
        }

        public bool IsRequired
        {
            get
            {
                return this.requiredPropertyHelper.Value;
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
                if (value < 0 || value > 4000)
                {
                    throw new ArgumentOutOfRangeException("value");
                }

                this.RaiseAndSetIfChanged(ref this.maximumLength, value);
            }
        }

        public int RemainingSpace
        {
            get
            {
                return this.remainingSpacePropertyHelper.Value;
            }
        }

        public string Text
        {
            get
            {
                return this.text;
            }

            set
            {
                this.RaiseAndSetIfChanged(ref this.text, value);
            }
        }

        public bool IsValid
        {
            get
            {
                return this.isValidPropertyHelper.Value;
            }
        }

        private static bool GetIsValidFlag(IObservedChange<TextInputControlGroupViewModel, string> textValidationFailureMessageObservedChange)
        {
            return string.IsNullOrWhiteSpace(textValidationFailureMessageObservedChange.GetValue());
        }

        private static int GetRemainingSpace(
            IObservedChange<TextInputControlGroupViewModel, string> textObservedChange,
            IObservedChange<TextInputControlGroupViewModel, int> maximumLengthObservedChange)
        {
            var t = textObservedChange.GetValue();
            var m = maximumLengthObservedChange.GetValue();

            if (string.IsNullOrWhiteSpace(t))
            {
                return m;
            }

            return m - t.Length;
        }

        private string GetValidationFailureMessage(
            IObservedChange<TextInputControlGroupViewModel, string> textObservedChange,
            IObservedChange<TextInputControlGroupViewModel, bool> isRequiredObservedChange,
            IObservedChange<TextInputControlGroupViewModel, int> maximumLengthObservedChange)
        {
            var t = textObservedChange.GetValue();
            var r = isRequiredObservedChange.GetValue();

            if (string.IsNullOrEmpty(t))
            {
                if (r)
                {
                    return "Required";
                }
            }

            if (this.extendedValidator != null)
            {
                return extendedValidator(t);
            }

            return null;
        }
    }
}
