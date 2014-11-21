using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.Whipstaff.Model.Info
{
    public class ValidationDetails
    {
        private ValidationIndicator validationIndicator;
        private string feedbackMessage;

        public ValidationDetails(
            ValidationIndicator validationIndicator,
            string feedbackMessage)
        {
            this.validationIndicator = validationIndicator;
            this.feedbackMessage = feedbackMessage;
        }

        public ValidationIndicator ValidationIndicator
        {
            get
            {
                return validationIndicator;
            }
            private set
            {
                this.validationIndicator = value;
            }
        }

        public string FeedbackMessage
        {
            get
            {
                return feedbackMessage;
            }
            private set
            {
                this.feedbackMessage = value;
            }
        }
    }
}
