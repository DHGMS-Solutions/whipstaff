namespace Dhgms.Whipstaff.Model.Excptn.Security
{
    public class TerminalServerSessionNotAllowed
        : System.Exception
    {
        public TerminalServerSessionNotAllowed()
            : base("Connections are not allowed whilst using remote desktop or terminal server")
        {
        }
    }
}
