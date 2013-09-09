using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.Whipstaff.ViewModel
{
    using ReactiveUI;

    public class BaseClosable<TInheritingClass> : Base<TInheritingClass>, IClosableViewModel
        where TInheritingClass : Base<TInheritingClass>
    {
        public ReactiveCommand CloseWindow { get; private set; }
    }
}
