namespace Dhgms.Whipstaff.Model.Excptn.OperatingSystem
{
    public class LessThanMinimumVersion
        : System.Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LessThanMinimumVersion"/> class.
        /// </summary>
        /// <param name="versionFriendlyName">
        /// The version friendly name.
        /// </param>
        /// <param name="minMajor">
        /// The min major.
        /// </param>
        /// <param name="minMinor">
        /// The min minor.
        /// </param>
        /// <param name="minRevision">
        /// The min revision.
        /// </param>
        /// <param name="minBuild">
        /// The min build.
        /// </param>
        public LessThanMinimumVersion(
            string versionFriendlyName,
            int minMajor,
            int minMinor,
            int minRevision,
            int minBuild)
            : base("The windows operating system you are using is not a recent enough version.  Requires " + versionFriendlyName + "(" + minMajor + "." + minMinor + "." + minRevision + "." + minBuild + ").")
        {
        }
    }
}
