using ReactiveUI;

namespace Dhgms.Whipstaff.Core.ViewModels
{
    public interface IListViewModel<T> : IReactiveObject
    {
        DynamicData.IObservableList<T> Items { get; }
    }
}