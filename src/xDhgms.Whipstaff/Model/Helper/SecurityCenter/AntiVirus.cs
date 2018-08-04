namespace Dhgms.Whipstaff.Model.Helper.SecurityCenter
{
    using Dhgms.Whipstaff.Model.Excptn.Security.AntiVirus;
    using Dhgms.Whipstaff.Model.Info;

    using UnexpectedProductState = Dhgms.Whipstaff.Model.Excptn.Security.AntiVirus.UnexpectedProductState;

    /// <summary>
    /// Checks on the security center status for the anti virus
    /// </summary>
    public class AntiVirus : Base
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AntiVirus"/> class.
        /// </summary>
        public AntiVirus()
            : base(SecurityProvider.WscSecurityProviderAntivirus)
        {
        }

        protected override void OnBadHealthState(SecurityProviderHealth health)
        {
            throw new UnexpectedProductState(health);
        }
    }
}
