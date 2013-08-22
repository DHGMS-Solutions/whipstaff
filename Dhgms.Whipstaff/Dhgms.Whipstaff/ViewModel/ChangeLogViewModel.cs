using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dhgms.Whipstaff.ViewModel
{
    using ReactiveUI;

    public class ChangeLogViewModel : BaseClosable, IChangeLogViewModel
    {
        private string[] changes;

        /// <summary>
        /// Gets or sets the Name of the program
        /// </summary>
        public string[] Changes
        {
            get
            {
                return this.changes;
            }

            set
            {
                this.RaiseAndSetIfChanged(ref this.changes, value);
            }
        }
    }
}
