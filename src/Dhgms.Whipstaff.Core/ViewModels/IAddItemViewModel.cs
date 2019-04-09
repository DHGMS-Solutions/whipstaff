using System.Reactive;
using ReactiveUI;

namespace Dhgms.Whipstaff.Core.ViewModels
{
    public interface IAddItemViewModel<T> : IReactiveObject
    {
        ReactiveCommand<Unit, T> Add { get; }
    }
}