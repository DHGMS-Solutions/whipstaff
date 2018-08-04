using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.Whipstaff.Model.ControlData.Button
{
    using ReactiveUI;

    public class ButtonItem
    {
        public string Name { get; set; }

        public ReactiveCommand Command { get; set; }
    }
}
