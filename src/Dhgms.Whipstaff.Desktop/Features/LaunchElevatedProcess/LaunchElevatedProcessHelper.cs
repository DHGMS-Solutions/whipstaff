using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.Whipstaff.Desktop.Features.LaunchElevatedProcess
{
    public static class LaunchElevatedProcessHelper
    {
        public static void DoElevatedProcess(string[] arguments)
        {
            var processStartInfo = new ProcessStartInfo
            {
                FileName = System.Reflection.Assembly.GetEntryAssembly().CodeBase
            };

            var argumentsToPass = arguments != null && arguments.Length > 0 ? string.Join(" ", arguments) : null;
            if (!string.IsNullOrWhiteSpace(argumentsToPass))
            {
                processStartInfo.Arguments = argumentsToPass;
            }

            processStartInfo.Verb = "runas";
            processStartInfo.WindowStyle = ProcessWindowStyle.Normal;
            processStartInfo.UseShellExecute = true;

            Process.Start(processStartInfo);
        }
    }
}
