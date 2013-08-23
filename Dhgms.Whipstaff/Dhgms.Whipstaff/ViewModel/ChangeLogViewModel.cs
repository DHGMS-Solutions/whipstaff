using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dhgms.Whipstaff.ViewModel
{
    using ReactiveUI;

    public class ChangeLogViewModel : BaseClosable, IChangeLogViewModel
    {
        private ReactiveList<Model.Info.VersionHistory> versions;

        /// <summary>
        /// Gets or sets the Name of the program
        /// </summary>
        public ReactiveList<Model.Info.VersionHistory> Versions
        {
            get
            {
                return this.versions;
            }

            set
            {
                this.RaiseAndSetIfChanged(ref this.versions, value);
            }
        }
    }
}
