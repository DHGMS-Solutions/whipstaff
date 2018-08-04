using System.Reactive;

namespace Dhgms.Whipstaff.Core.ViewModels
{
    using ReactiveUI;

    /// <summary>
    /// Interface for a savable view model. Something where the view can be edited.
    /// </summary>
    public interface ISavable : IClosableViewModel
    {
        /// <summary>
        /// Gets the Save Command
        /// </summary>
        ReactiveCommand<Unit, Unit> Save { get; }

        /// <summary>
        /// Gets the Cancel Command
        /// </summary>
        ReactiveCommand<Unit, Unit> Cancel { get; }
    }
}
