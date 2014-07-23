namespace Dhgms.Whipstaff.ViewModel
{
    using System.Collections.Generic;

    using Dhgms.Whipstaff.Model.Info;

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
