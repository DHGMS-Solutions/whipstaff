using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.Whipstaff.ViewModel
{
    using System.Reflection;

    using ReactiveUI;

    /// <summary>
    /// View Model for the About View
    /// </summary>
    public class AboutViewModel : ViewModelBaseClosable<AboutViewModel>, IAboutViewModel
    {
        /// <summary>
        /// The program name
        /// </summary>
        private string programName;

        /// <summary>
        /// The program version
        /// </summary>
        private string programVersion;

        /// <summary>
        /// Program copyright
        /// </summary>
        private string copyright;

        /// <summary>
        /// Program Legal Notice
        /// </summary>
        private string notice;

        /// <summary>
        /// Program Dependencies
        /// </summary>
        private IEnumerable<Assembly> dependencies;

        /// <summary>
        /// Gets or sets the Name of the program
        /// </summary>
        public string ProgramName
        {
            get
            {
                return this.programName;
            }

            set
            {
                this.RaiseAndSetIfChanged(ref this.programName, value);
            }
        }

        /// <summary>
        /// Gets or sets the Version of the program
        /// </summary>
        public string ProgramVersion
        {
            get
            {
                return this.programVersion;
            }

            set
            {
                this.RaiseAndSetIfChanged(ref this.programVersion, value);
            }
        }

        /// <summary>
        /// Gets or sets the Copyright information
        /// </summary>
        public string Copyright
        {
            get
            {
                return this.copyright;
            }

            set
            {
                this.RaiseAndSetIfChanged(ref this.copyright, value);
            }
        }

        /// <summary>
        /// Gets or sets the Legal Notice for program usage
        /// </summary>
        public string Notice
        {
            get
            {
                return this.notice;
            }

            set
            {
                this.RaiseAndSetIfChanged(ref this.notice, value);
            }
        }

        /// <summary>
        /// Gets or sets the list of assemblies the program is using
        /// </summary>
        public IEnumerable<Assembly> Dependencies
        {
            get
            {
                return this.dependencies;
            }

            set
            {
                this.RaiseAndSetIfChanged(ref this.dependencies, value);
            }
        }
    }
}
