namespace Dhgms.Whipstaff.Model.Excptn
{
    public class ApplicationCompatabilityModeException
        : System.Exception
    {
        public ApplicationCompatabilityModeException()
            : base("This application is not allowed to run in compatability mode")
        {
        }
    }
}
