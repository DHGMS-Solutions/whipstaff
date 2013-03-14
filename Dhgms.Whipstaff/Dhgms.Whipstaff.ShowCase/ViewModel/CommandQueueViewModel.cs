using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.Whipstaff.ShowCase.ViewModel
{
    using Dhgms.Whipstaff.ShowCase.Model.Info;

    using ReactiveUI;
    using ReactiveUI.Routing;

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
                this.RaiseAndSetIfChanged(x => x.QueueStatus, ref this.queueStatus, value);
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
                this.RaiseAndSetIfChanged(x => x.Commands, ref this.commands, value);
            }
        }
    }
}
