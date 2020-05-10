using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.Whipstaff.Model
{
    public class FeatureUsageTracking
    {
        private static FeatureUsageTracking singleton;

        private readonly Dictionary<string, Guid> providerApplicationSessions;

        public FeatureUsageTracking GetSingleton()
        {
            return singleton ?? (singleton = new FeatureUsageTracking());
        }

        private FeatureUsageTracking()
        {
            this.providerApplicationSessions = new Dictionary<string, Guid>();
        }

        public void OnApplicationStart()
        {
            
        }

        public void OnApplicationEnd()
        {
            
        }

        public void OnFeatureStart()
        {
            
        }

        public void OnFeatureEnd()
        {
            
        }

        public void OnFeatureError()
        {
            
        }

        public void OnFeatureException()
        {
            
        }
    }
}
