namespace Dhgms.Whipstaff.Core.ViewModels
{
    using Dhgms.Whipstaff.Core.Model;

    using ReactiveUI;

    public interface IChangeLogViewModel
    {
        /// <summary>
        /// Gets or sets the collection of changes
        /// </summary>
        DynamicData.SourceList<VersionHistory> Versions { get; set; }
    }
}
