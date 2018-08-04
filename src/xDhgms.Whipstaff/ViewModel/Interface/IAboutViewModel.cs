namespace Dhgms.Whipstaff.ViewModel
{
    using System.Collections.Generic;
    using System.Reflection;

    using ReactiveUI;
    using ReactiveUI.Xaml;

    /// <summary>
    /// View Model Interface for the About View
    /// </summary>
    public interface IAboutViewModel //: IRoutableViewModel
    {
        /// <summary>
        /// Gets or sets the Name of the program
        /// </summary>
        string ProgramName { get; set; }

        /// <summary>
        /// Gets or sets the Version of the program
        /// </summary>
        string ProgramVersion { get; set; }

        /// <summary>
        /// Gets or sets the Copyright information
        /// </summary>
        string Copyright { get; set; }

        /// <summary>
        /// Gets or sets the Legal Notice for program usage
        /// </summary>
        string Notice { get; set; }

        /// <summary>
        /// Gets or sets the list of assemblies the program is using
        /// </summary>
        IEnumerable<Assembly> Dependencies { get; set; }
        
        /// <summary>
        /// Gets the Close Window Command
        /// </summary>
        ReactiveCommand CloseWindow { get; }
    }
}
