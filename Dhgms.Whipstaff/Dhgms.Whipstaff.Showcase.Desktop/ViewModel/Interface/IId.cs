namespace Dhgms.Whipstaff.ShowCase.ViewModel.Interface
{
    /// <summary>
    /// Interface for a class that has a Unique Id property
    /// </summary>
    /// <typeparam name="TPropertyType">
    /// The type for the property.
    /// </typeparam>
    public interface IId<TPropertyType>
    {
        /// <summary>
        /// Gets or sets the Unique Id
        /// </summary>
        TPropertyType Id { get; set; }
    }
}
