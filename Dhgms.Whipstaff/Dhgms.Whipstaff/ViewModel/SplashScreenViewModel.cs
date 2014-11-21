namespace Dhgms.Whipstaff.ViewModel
{
    using ReactiveUI;

    /// <summary>
    /// Splash Screen View Model
    /// </summary>
    public class SplashScreenViewModel : ViewModelBase<SplashScreenViewModel>, ISplashScreenViewModel
    {
        /// <summary>
        /// Name of the program
        /// </summary>
        private string programName;

        /// <summary>
        /// Version of the program
        /// </summary>
        private string programVersion;

        /// <summary>
        /// The name of the company
        /// </summary>
        private string companyName;

        /// <summary>
        /// Get and sets the Name of the company
        /// </summary>
        public string CompanyName
        {
            get
            {
                return this.companyName;
                
            }

            set
            {
                this.RaiseAndSetIfChanged(ref this.companyName, value);
            }
        }

        /// <summary>
        /// Get and sets the Name of the program
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
        /// Get and sets the Version of the program
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
    }
}
