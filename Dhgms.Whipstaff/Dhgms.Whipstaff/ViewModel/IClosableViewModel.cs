namespace Dhgms.Whipstaff.ViewModel
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
        ReactiveCommand CloseWindow { get; }
    }
}
