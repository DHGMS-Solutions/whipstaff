using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.Whipstaff.ViewModel
{
    using ReactiveUI;

    public class IntegerTextBoxViewModel : TextBoxViewControl
    {
        protected int maximum;

        protected int minimum;

        protected new ObservableAsPropertyHelper<int> maximumLength;

        public IntegerTextBoxViewModel()
        {
            this.maximumLength = this.WhenAny(x => x.Minimum, x => x.Maximum, GetMaximumLength).ToProperty(this, x => x.MaximumLength);
        }

        public int Maximum
        {
            get
            {
                return this.maximum;
            }
            set
            {
                this.RaiseAndSetIfChanged(ref this.maximum, value);
            }
        }

        public int Minimum
        {
            get
            {
                return this.minimum;
            }
            set
            {
                this.RaiseAndSetIfChanged(ref this.minimum, value);
            }
        }

        public new int MaximumLength
        {
            get
            {
                return this.maximumLength.Value;
            }
        }

        private int GetMaximumLength(IObservedChange<IntegerTextBoxViewModel, int> min, IObservedChange<IntegerTextBoxViewModel, int> max)
        {
            var minStringLength = min.Value.ToString().Length;
            var maxStringLength = max.Value.ToString().Length;

            return Math.Max(minStringLength, maxStringLength);
        }
    }
}
