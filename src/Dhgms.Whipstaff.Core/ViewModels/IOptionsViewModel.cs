using System.Reactive;

namespace Dhgms.Whipstaff.Core.ViewModels
{
    using ReactiveUI;

    /// <summary>
    /// Interface for the Options View Model
    /// </summary>
    public interface IOptionsViewModel
    {
        /// <summary>
        /// Gets the command handler for saving changes
        /// </summary>
        ReactiveCommand<Unit, Unit> SaveChanges { get; }

        /// <summary>
        /// Gets the command handler for canceling changes
        /// </summary>
        ReactiveCommand<Unit, Unit> CancelChanges { get; }
    }
}
