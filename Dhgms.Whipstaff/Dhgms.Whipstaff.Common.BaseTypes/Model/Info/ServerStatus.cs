namespace Dhgms.Whipstaff.Common.Model.Info
{
    /// <summary>
    /// Enumeration representing the different server statuses
    /// </summary>
    public enum ServerStatus
    {
        /// <summary>
        /// Server status is unknown
        /// </summary>
        Unknown,

        /// <summary>
        /// Server is Offline.
        /// </summary>
        Offline,

        /// <summary>
        /// Server is locked. Normal users can't connect.  Used during maintenance to test a server.
        /// </summary>
        Locked,

        /// <summary>
        /// Server is online and available to normal users.
        /// </summary>
        Online
    }
}
