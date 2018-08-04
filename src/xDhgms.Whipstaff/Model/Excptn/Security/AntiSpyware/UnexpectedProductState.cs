﻿namespace Dhgms.Whipstaff.Model.Excptn.Security.AntiSpyware
{
    using Dhgms.Whipstaff.Model.Info;

    public class UnexpectedProductState
        : System.Exception
    {
        public UnexpectedProductState(SecurityProviderHealth healthState)
            : base("Anti-Spyware in unexpected Product State: " + (int)healthState)
        {
        }
    }
}
