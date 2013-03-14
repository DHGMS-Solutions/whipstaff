using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.Whipstaff.ShowCase.Model.Info
{
    public enum CommandStatus
    {
        Unknown,

        Queued,

        Running,

        Cancelled,

        Completed,

        Failed,

        DuplicateQueued
    }
}
