namespace Dhgms.Whipstaff.Core.ViewModels
{
    public interface ISelectItemViewModel<T>
    {
        T SelectedItem { get; set; }
    }
}