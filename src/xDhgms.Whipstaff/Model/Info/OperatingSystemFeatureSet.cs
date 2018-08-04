// -----------------------------------------------------------------------
// <copyright file="OperatingSystemFeatureSet.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Dhgms.Whipstaff.Model.Info
{
    /// <summary>
    /// Enumeration of the different Operating System feature sets we support
    /// </summary>
    public enum OperatingSystemFeatureSet
    {
        /// <summary>
        /// Operating System is too old
        /// </summary>
        None,

        /// <summary>
        /// Operating System is Windows Vista or later
        /// </summary>
        WindowsVistaOrLater,

        /// <summary>
        /// Operating System is Windows 7 or later
        /// </summary>
        Windows7OrLater,

        /// <summary>
        /// Operating System is Windows 8 or later
        /// </summary>
        Windows8OrLater
    }
}
