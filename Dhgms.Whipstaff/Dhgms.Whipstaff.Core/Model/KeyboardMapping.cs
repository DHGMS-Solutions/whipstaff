namespace Dhgms.Whipstaff.Core.Model
{
    using ReactiveUI;

    /// <summary>
    /// The keyboard mapping.
    /// </summary>
    public class KeyboardMapping
    {
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the application command.
        /// </summary>
        public IReactiveCommand ApplicationCommand { get; set; }
    }
}
