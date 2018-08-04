namespace Dhgms.Whipstaff.Model.Excptn.Security.AntiVirus
{
    using Dhgms.Whipstaff.Model.Info;

    class UnexpectedProductState
		: System.Exception
	{
        public UnexpectedProductState(SecurityProviderHealth healthState)
            : base("Anti-Virus in unexpected Product State: " + (int)healthState)
        {
        }
	}
}
