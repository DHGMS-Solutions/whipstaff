using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.Whipstaff.ViewModel
{
    using ReactiveUI;

    /// <summary>
    /// Base class for a savable window
    /// </summary>
    public class BaseSavable : ISavable
    {
        /// <summary>
        /// Gets the save.
        /// </summary>
        public ReactiveCommand<object> Save { get; private set; }

        /// <summary>
        /// Gets the cancel.
        /// </summary>
        public ReactiveCommand<object> Cancel { get; private set; }

        /// <summary>
        /// Gets the Close Window Command
        /// </summary>
        public ReactiveCommand<object> CloseWindow { get; private set; }
    }
}
