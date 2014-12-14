namespace Dhgms.Whipstaff.Model.Excptn
{
    using System;

    /// <summary>
    /// The exception which is thrown when trying to initialize a second application instance, and the <see cref="SingleInstanceManager"/>
    /// is set to <see cref="TerminationOption.Throw"/>.
    /// </summary>
    public sealed class ApplicationInstanceAlreadyExistsException : Exception
    {
        public ApplicationInstanceAlreadyExistsException()
            : base("Application instance already exists")
        { }
    }
}
