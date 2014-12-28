namespace Dhgms.Whipstaff.Showcase.Desktop.ViewModel
{
    using System.Collections.Generic;

    using Dhgms.Whipstaff.Showcase.Desktop.ViewModel.Interface;

    using ReactiveUI;

    public class FloorViewModel : ReactiveObject, IFloorViewModel, IRoutableViewModel
    {
        public string UrlPathSegment
        {
            get
            {
                return "FloorView";
            }
        }

        public IScreen HostScreen { get; protected set; }

        public string BuildingName { get; set; }

        public string FloorName { get; set; }

        public List<TeamViewModel> Teams { get; set; }
    }
}
