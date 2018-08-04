using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dhgms.Whipstaff.Model.Info
{
    using System.Windows.Input;

    /// <summary>
    /// The keyboard mapping.
    /// </summary>
    public class KeyboardMapping
    {
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the application command.
        /// </summary>
        public RoutedUICommand ApplicationCommand { get; set; }
    }
}
