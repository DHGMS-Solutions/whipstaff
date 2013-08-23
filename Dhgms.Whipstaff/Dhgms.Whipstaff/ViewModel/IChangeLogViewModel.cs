using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dhgms.Whipstaff.ViewModel
{
    using ReactiveUI;

    public interface IChangeLogViewModel : IRoutableViewModel
    {
        /// <summary>
        /// Gets or sets the collection of changes
        /// </summary>
        ReactiveList<Model.Info.VersionHistory> Versions { get; set; }
    }
}
