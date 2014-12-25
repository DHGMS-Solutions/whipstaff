namespace Dhgms.Whipstaff.Showcase.Desktop.ViewModel
{
    using System.Collections.Generic;

    using Dhgms.Whipstaff.Showcase.Desktop.Model.Info;
    using Dhgms.Whipstaff.Showcase.Desktop.ViewModel.Interface;

    using ReactiveUI;

    public class CommandQueueViewModel : ReactiveObject, ICommandQueueViewModel, IRoutableViewModel
    {
        private QueueStatus queueStatus;

        private IList<string> commands;

        public string UrlPathSegment
        {
            get
            {
                return "CommandQueue";
            }
        }

        public IScreen HostScreen { get; protected set; }

        /// <summary>
        /// Gets or sets the current Status of the Queue Processor
        /// </summary>
        public QueueStatus QueueStatus
        {
            get
            {
                return this.queueStatus;
            }

            set
            {
                this.RaiseAndSetIfChanged(ref this.queueStatus, value);
            }
        }

        /// <summary>
        /// Gets or sets the collection of commands in the queue
        /// </summary>
        public IList<string> Commands
        {
            get
            {
                return this.commands;
            }

            set
            {
                this.RaiseAndSetIfChanged(ref this.commands, value);
            }
        }
    }
}
