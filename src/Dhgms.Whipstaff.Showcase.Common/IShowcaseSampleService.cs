namespace Dhgms.Whipstaff.Showcase.Common
{
    using System.Collections.Generic;

    public interface IShowcaseSampleService
    {
        ICollection<string> GetCrossPlatformSamples();
        
        ICollection<string> GetNativeSamples();
    }
}
