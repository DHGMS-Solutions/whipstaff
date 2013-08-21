namespace Dhgms.Whipstaff.Model.Excptn.Security.AntiVirus
{
    public class NotFound
		: System.SystemException
	{
		public NotFound()
			: base("No Anti-Virus product was detected!")
		{
		}
	}
}
