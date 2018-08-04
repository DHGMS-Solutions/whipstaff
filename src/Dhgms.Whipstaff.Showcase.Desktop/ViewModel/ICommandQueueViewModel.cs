namespace Dhgms.Whipstaff.Showcase.Desktop.ViewModel.Interface
{
    using System.Collections.Generic;

    using Dhgms.Whipstaff.Showcase.Desktop.Model.Info;

    /// <summary>
    /// Interface for the Command Queue View Model
    /// </summary>
    public interface ICommandQueueViewModel
    {
        /// <summary>
        /// Gets or sets the current Status of the Queue Processor
        /// </summary>
        QueueStatus QueueStatus { get; set; }

        /// <summary>
        /// Gets or sets the collection of commands in the queue
        /// </summary>
        IList<string> Commands { get; set; }
    }
}
