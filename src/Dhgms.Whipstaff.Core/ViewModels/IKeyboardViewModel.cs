namespace Dhgms.Whipstaff.Core.ViewModels
{
    using System.Collections.Generic;

    using Dhgms.Whipstaff.Core.Model;

    /// <summary>
    /// The Keyboard View Model interface.
    /// </summary>
    public interface IKeyboardViewModel : IClosableViewModel
    {
        /// <summary>
        /// Gets or sets the keyboard mappings.
        /// </summary>
        List<KeyboardMapping> KeyboardMappings { get; set; }
    }
}
