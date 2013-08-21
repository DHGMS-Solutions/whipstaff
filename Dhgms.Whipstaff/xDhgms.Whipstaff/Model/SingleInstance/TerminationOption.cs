namespace Dhgms.Whipstaff.Model.SingleInstance
{
    using Dhgms.Whipstaff.Model.Excptn;

    /// <summary>
    /// Represents the action to perform when trying to initialize a <see cref="SingleInstanceManager"/>
    /// which is not the first application instance.
    /// </summary>
    public enum TerminationOption
    {
        /// <summary>
        /// Exit the application using <see cref="System.Environment.Exit"/>.
        /// </summary>
        Exit,

        /// <summary>
        /// Throw an <see cref="ApplicationInstanceAlreadyExistsException"/>.
        /// </summary>
        Throw
    }
}
