namespace Dhgms.Whipstaff.Showcase.Desktop.ViewModel.Interface
{
    using System.Collections.Generic;

    public interface IServerSelectionViewModel
    {
        IList<IServerViewModel> Servers { get; set; }
    }
}
