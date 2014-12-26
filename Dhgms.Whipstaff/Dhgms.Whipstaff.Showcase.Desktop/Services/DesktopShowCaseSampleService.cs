namespace Dhgms.Whipstaff.Showcase.Desktop.Services
{
    using System.Collections.Generic;

    using Dhgms.Whipstaff.Showcase.Common;

    public sealed class DesktopShowCaseSampleService : ShowCaseSampleServiceBase
    {
        private readonly ICollection<string> nativeSamples;

        public DesktopShowCaseSampleService()
        {
            nativeSamples = new List<string>
                {
                    "Developer Console",
                    "Toolbar Window",
                    "Multi Screen Support"
                };
        }

        public override ICollection<string> GetNativeSamples()
        {
            return nativeSamples;
        }
    }
}
