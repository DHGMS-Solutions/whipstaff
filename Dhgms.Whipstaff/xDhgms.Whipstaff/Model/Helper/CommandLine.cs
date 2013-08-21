using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.Whipstaff.Model.Helper
{
    public class CommandLine : ICommandLine<Info.CommandLineArguments>
    {
        public Info.CommandLineArguments GetCommandLineArguments()
        {
            return new Info.CommandLineArguments();
        }
    }
}
