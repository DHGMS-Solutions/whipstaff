using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.Whipstaff.ViewModel
{
    using Dhgms.Whipstaff.Model.Info;

    using ReactiveUI;
    using ReactiveUI.Xaml;

    /// <summary>
    /// The keyboard view model.
    /// </summary>
    public class KeyboardViewModel : BaseClosable<KeyboardViewModel>, IKeyboardViewModel
    {
        /// <summary>
        /// Gets or sets the keyboard mappings.
        /// </summary>
        public List<KeyboardMapping> KeyboardMappings { get; set; }
    }
}
