namespace Dhgms.Whipstaff.Core.Model
{
    public class ValidationDetails
    {
        public ValidationDetails(
            ValidationIndicator validationIndicator,
            string feedbackMessage)
        {
            this.ValidationIndicator = validationIndicator;
            this.FeedbackMessage = feedbackMessage;
        }

        public ValidationIndicator ValidationIndicator { get; private set; }

        public string FeedbackMessage { get; private set; }
    }
}
