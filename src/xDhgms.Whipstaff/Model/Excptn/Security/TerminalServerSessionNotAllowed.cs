namespace Dhgms.Whipstaff.Model.Excptn.Security
{
    class TerminalServerSessionNotAllowed
        : System.Exception
    {
        public TerminalServerSessionNotAllowed()
            : base("Connections are not allowed whilst using remote desktop or terminal server")
        {
        }
    }
}
