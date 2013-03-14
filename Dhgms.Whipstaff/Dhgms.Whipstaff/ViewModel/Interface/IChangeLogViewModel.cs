using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dhgms.Whipstaff.ViewModel
{
    using ReactiveUI.Routing;

    public interface IChangeLogViewModel : IRoutableViewModel
    {
        /// <summary>
        /// Gets or sets the collection of changes
        /// </summary>
        string[] Changes { get; set; }
    }
}
