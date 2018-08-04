using System.Reactive;

namespace Dhgms.Whipstaff.Core.ViewModels
{
    using ReactiveUI;

    /// <summary>
    /// Interface for a closable view model. typically something that is read only
    /// </summary>
    public interface IClosableViewModel
    {
        /// <summary>
        /// Gets the Close Window Command
        /// </summary>
        ReactiveCommand<Unit, Unit> CloseWindow { get; }
    }
}
