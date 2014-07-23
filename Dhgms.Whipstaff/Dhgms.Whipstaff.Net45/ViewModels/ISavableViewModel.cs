namespace Dhgms.Whipstaff.ViewModel
{
    /// <summary>
    /// Interface for a savable view model. Something where the view can be edited.
    /// </summary>
    public interface ISavable : IClosableViewModel
    {
        /// <summary>
        /// Gets the Save Command
        /// </summary>
        ReactiveCommand<object> Save { get; }

        /// <summary>
        /// Gets the Cancel Command
        /// </summary>
        ReactiveCommand<object> Cancel { get; }
    }
}
