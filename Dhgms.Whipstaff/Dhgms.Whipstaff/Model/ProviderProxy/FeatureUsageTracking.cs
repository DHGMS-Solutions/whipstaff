using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.Whipstaff.Model.ProviderProxy
{
    public class FeatureUsageTracking : Dhgms.DataManager.Model.ProviderProxy.Base<FeatureUsageTracking, Dhgms.Whipstaff.Model.ProviderBase.FeatureUsageTracking, Dhgms.Whipstaff.Model.ProviderCollection.FeatureUsageTracking, Dhgms.Whipstaff.Model.ProviderSection.FeatureUsageTracking>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureUsageTracking"/> class.
        /// </summary>
        public FeatureUsageTracking()
            : base("featureUsageTracking")
        {
        }
    }
}
