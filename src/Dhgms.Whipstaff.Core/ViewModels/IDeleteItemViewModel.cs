using System.Reactive;
using ReactiveUI;

namespace Dhgms.Whipstaff.Core.ViewModels
{
    public interface IDeleteItemViewModel<T> : IReactiveObject
    {
        ReactiveCommand<Unit, Unit> Delete { get; }
    }
}