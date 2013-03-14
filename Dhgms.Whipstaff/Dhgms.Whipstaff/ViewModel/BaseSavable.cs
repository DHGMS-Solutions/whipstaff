using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.Whipstaff.ViewModel
{
    using ReactiveUI.Xaml;

    /// <summary>
    /// Base class for a savable window
    /// </summary>
    public class BaseSavable : ISavable
    {
        /// <summary>
        /// Gets the save.
        /// </summary>
        public ReactiveCommand Save { get; private set; }

        /// <summary>
        /// Gets the cancel.
        /// </summary>
        public ReactiveCommand Cancel { get; private set; }

        /// <summary>
        /// Gets the Close Window Command
        /// </summary>
        public ReactiveCommand CloseWindow { get; private set; }
    }
}
