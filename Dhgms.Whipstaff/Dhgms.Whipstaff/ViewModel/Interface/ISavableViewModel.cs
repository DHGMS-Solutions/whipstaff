namespace Dhgms.Whipstaff.ViewModel
{
    using ReactiveUI.Xaml;

    /// <summary>
    /// Interface for a savable view model. Something where the view can be edited.
    /// </summary>
    public interface ISavable : IClosableViewModel
    {
        /// <summary>
        /// Gets the Save Command
        /// </summary>
        ReactiveCommand Save { get; }

        /// <summary>
        /// Gets the Cancel Command
        /// </summary>
        ReactiveCommand Cancel { get; }
    }
}
