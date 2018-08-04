namespace Dhgms.Whipstaff.Model.Excptn.Security.AntiSpyware
{
    public class NotFound
		: System.SystemException
	{
		public NotFound()
			: base("No Anti-Spyware product was detected!")
		{
		}
	}
}
