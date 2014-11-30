namespace Dhgms.Whipstaff.Model.Excptn.Security.AntiVirus
{
    using Dhgms.Whipstaff.Core.Model;

    class UnexpectedProductState
		: System.Exception
	{
        public UnexpectedProductState(SecurityProviderHealth healthState)
            : base("Anti-Virus in unexpected Product State: " + (int)healthState)
        {
        }
	}
}
