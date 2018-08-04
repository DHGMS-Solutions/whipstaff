namespace Dhgms.Whipstaff.Core.ViewModels
{
    using System.Collections.Generic;

    /// <summary>
    /// Interface for the permissions list view model
    /// </summary>
    public interface IPermissionsListViewModel
    {
        /// <summary>
        /// List of groups the user belongs to
        /// </summary>
        IList<string> Groups { get; set; }

        /// <summary>
        /// List of permissions the user has (role based)
        /// </summary>
        IList<string> Permissions { get; set; }
    }
}
