namespace Dhgms.Whipstaff.Showcase.Desktop.View.Generic
{
    using Dhgms.Whipstaff.Desktop.Controls;
    using Dhgms.Whipstaff.Showcase.Desktop.ViewModel.Interface;

    /// <summary>
    /// Wrappers for the Generic Class. This is done because of a WPF Designer Issue in Visual Studio 2012.
    /// </summary>
    public class FloorView : WhipstaffMetroWindow<FloorView, IFloorViewModel>
    {
        public FloorView(IFloorViewModel viewModel)
            : base(viewModel)
        {
        }
    }
}
