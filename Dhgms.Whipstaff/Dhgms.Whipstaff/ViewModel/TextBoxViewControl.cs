using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.Whipstaff.ViewModel
{
    using ReactiveUI;

    public class TextBoxViewControl : Dhgms.Whipstaff.ViewModel.Base
    {
        /// <summary>
        /// The actual value of the control.
        /// </summary>
        protected string actualValue;

        protected int maximumLength;

        /// <summary>
        /// Gets or sets the actual value of the control.
        /// </summary>
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
    }
}
