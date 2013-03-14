using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.Whipstaff.ViewModel
{
    using ReactiveUI;
    using ReactiveUI.Routing;
    using ReactiveUI.Xaml;

    public class OptionsViewModel : BaseClosable, IOptionsViewModel
    {
        /// <summary>
        /// Gets the command handler for saving changes
        /// </summary>
        public ReactiveCommand SaveChanges { get; private set; }

        /// <summary>
        /// Gets the command handler for canceling changes
        /// </summary>
        public ReactiveCommand CancelChanges { get; private set; }
    }
}
