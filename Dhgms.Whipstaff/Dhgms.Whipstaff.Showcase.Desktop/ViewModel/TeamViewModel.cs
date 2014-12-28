namespace Dhgms.Whipstaff.Showcase.Desktop.ViewModel
{
    using System.Collections.Generic;

    using Dhgms.Whipstaff.Showcase.Desktop.ViewModel.Interface;

    using ReactiveUI;

    public class TeamViewModel : ReactiveObject, ITeamViewModel, IRoutableViewModel
    {
        public string UrlPathSegment
        {
            get
            {
                return "TeamView";
            }
        }

        public IScreen HostScreen { get; protected set; }

        public string Name { get; set; }

        public IEmployeeViewModel Leader { get; set; }

        public IList<IEmployeeViewModel> Members { get; set; }
    }
}
