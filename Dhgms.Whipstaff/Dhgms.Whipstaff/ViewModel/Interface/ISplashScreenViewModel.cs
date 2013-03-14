namespace Dhgms.Whipstaff.ViewModel
{
    using ReactiveUI.Routing;

    /// <summary>
    /// View Model for the splash screen
    /// </summary>
    public interface ISplashScreenViewModel : IRoutableViewModel
    {
        /// <summary>
        /// Gets or sets the Name of the program
        /// </summary>
        string ProgramName { get; set; }

        /// <summary>
        /// Gets or sets the Version of the program
        /// </summary>
        string ProgramVersion { get; set; }
    }
}
