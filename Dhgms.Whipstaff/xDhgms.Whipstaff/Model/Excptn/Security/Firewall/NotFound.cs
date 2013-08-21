namespace Dhgms.Whipstaff.Model.Excptn.Security.Firewall
{
    public class NotFound
        : System.SystemException
    {
        public NotFound()
            : base("No firewall product was detected!")
        {
        }
    }
}
