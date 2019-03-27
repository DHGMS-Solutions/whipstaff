using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.Whipstaff.Desktop.Features.GroupPolicyMonitoring
{
    public sealed class GroupPolicyMonitoringProcessManager : IDisposable, IEnableLogger
    {
        public GroupPolicyMonitoringProcessManager()
        {

        }

        public void Run()
        {
            SystemEvents.UserPreferenceChanging += this.SystemEventsOnUserPreferenceChanging;
        }

        public void Stop()
        {
            SystemEvents.UserPreferenceChanging -= this.SystemEventsOnUserPreferenceChanging;
        }

        public void Dispose()
        {
            SystemEvents.UserPreferenceChanging -= this.SystemEventsOnUserPreferenceChanging;
        }

        private void SystemEventsOnUserPreferenceChanging(object sender, UserPreferenceChangingEventArgs userPreferenceChangingEventArgs)
        {
            switch (userPreferenceChangingEventArgs.Category)
            {
                case UserPreferenceCategory.Policy:
                    this.Log().Info("Group Policy Refresh Detected");
                    this.OnGroupPolicyRefresh();
                    break;
            }
        }

        private s OnGroupPolicyRefresh()
        {
            throw new NotImplementedException();
        }
    }
}
