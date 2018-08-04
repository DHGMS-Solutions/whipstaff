namespace Dhgms.Whipstaff.ViewModel
{
    using ReactiveUI;
    using ReactiveUI.Xaml;

    /// <summary>
    /// Interface for the Options View Model
    /// </summary>
    public interface IOptionsViewModel : IRoutableViewModel
    {
        /// <summary>
        /// Gets the command handler for saving changes
        /// </summary>
        ReactiveCommand SaveChanges { get; }

        /// <summary>
        /// Gets the command handler for canceling changes
        /// </summary>
        ReactiveCommand CancelChanges { get; }
    }
}
