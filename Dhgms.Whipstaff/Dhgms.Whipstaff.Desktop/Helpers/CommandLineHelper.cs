using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.Whipstaff.Desktop.Helpers
{
    using System;
    using System.Linq;

    using MahAppsMetroWpfSpike.Models;

    internal static class CommandLineHelper
    {
        private static readonly Lazy<CommandLineModel> LazyCommandLineModel = new Lazy<CommandLineModel>(LazyGetCommandLineModel);

        internal static CommandLineModel GetCommandLineModel()
        {
            return LazyCommandLineModel.Value;
        }

        private static CommandLineModel LazyGetCommandLineModel()
        {
            var commandLineArgs = Environment.GetCommandLineArgs();

            var result = new CommandLineModel
            {
                DeveloperMode = commandLineArgs.Any(x => x.Equals("/devmode"))
            };

            return result;
        }
    }
}
