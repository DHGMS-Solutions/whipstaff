namespace Dhgms.Whipstaff.ViewModel
{
    using ReactiveUI;
    using ReactiveUI.Routing;

    /// <summary>
    /// Splash Screen View Model
    /// </summary>
    public class SplashScreenViewModel : Base, ISplashScreenViewModel
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
        /// Gets the Name of the program
        /// </summary>
        public string ProgramName
        {
            get
            {
                return this.programName;
            }

            set
            {
                this.RaiseAndSetIfChanged(x => x.ProgramName, ref this.programName, value);
            }
        }

        /// <summary>
        /// Gets the Version of the program
        /// </summary>
        public string ProgramVersion
        {
            get
            {
                return this.programVersion;
            }

            set
            {
                this.RaiseAndSetIfChanged(x => x.ProgramVersion, ref this.programVersion, value);
            }
        }
    }
}
