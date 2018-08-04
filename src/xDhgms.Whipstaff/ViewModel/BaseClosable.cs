using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.Whipstaff.ViewModel
{
    using ReactiveUI;

    public class BaseClosable : Base, IClosableViewModel
    {
        public ReactiveCommand CloseWindow { get; private set; }
    }
}
