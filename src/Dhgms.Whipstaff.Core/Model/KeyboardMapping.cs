using System.Reactive;

namespace Dhgms.Whipstaff.Core.Model
{
    using ReactiveUI;

    /// <summary>
    /// The keyboard mapping.
    /// </summary>
    public class KeyboardMapping
    {
        public ModifierKeys KeyboardModifierKeys { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the application command.
        /// </summary>
        public ReactiveCommand<Unit, Unit> ApplicationCommand { get; set; }
    }
}
