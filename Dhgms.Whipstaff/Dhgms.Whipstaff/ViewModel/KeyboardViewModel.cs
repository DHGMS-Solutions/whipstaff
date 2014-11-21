using System.Collections.Generic;

namespace Dhgms.Whipstaff.ViewModel
{
    using Dhgms.Whipstaff.Model.Info;

    /// <summary>
    /// The keyboard view model.
    /// </summary>
    public class KeyboardViewModel : ViewModelBaseClosable<KeyboardViewModel>, IKeyboardViewModel
    {
        /// <summary>
        /// Gets or sets the keyboard mappings.
        /// </summary>
        public List<KeyboardMapping> KeyboardMappings { get; set; }
    }
}
