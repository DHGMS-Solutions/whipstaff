using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.Whipstaff.Model.Helper
{
    public interface ICommandLine<TCommandLineArgumentsClass>
        where TCommandLineArgumentsClass : Info.CommandLineArguments
    {
        TCommandLineArgumentsClass GetCommandLineArguments();
    }
}
