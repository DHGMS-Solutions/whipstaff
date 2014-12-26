using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.Whipstaff.Showcase.Common
{
    public abstract class ShowCaseSampleServiceBase : IShowcaseSampleService
    {
        private readonly ICollection<string> crossPlatformSamples;

        protected ShowCaseSampleServiceBase()
        {
            crossPlatformSamples = new List<string>
                {
                    "Address Search",
                    "Building Viewer",
                    "Theme Selector"
                };
        }

        public ICollection<string> GetCrossPlatformSamples()
        {
            return crossPlatformSamples;
        }

        public abstract ICollection<string> GetNativeSamples();
    }
}
