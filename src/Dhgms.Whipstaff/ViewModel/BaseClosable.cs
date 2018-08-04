using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.Whipstaff.ViewModel
{
    using ReactiveUI;

    public class ViewModelBaseClosable<TInheritingClass> : ViewModelBase<TInheritingClass>, IClosableViewModel
        where TInheritingClass : ViewModelBase<TInheritingClass>
    {
        public ReactiveCommand<object> CloseWindow { get; private set; }
    }
}
