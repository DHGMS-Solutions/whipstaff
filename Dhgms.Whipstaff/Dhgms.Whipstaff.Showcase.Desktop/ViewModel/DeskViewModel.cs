namespace Dhgms.Whipstaff.Showcase.Desktop.ViewModel
{
    using Dhgms.Whipstaff.Showcase.Desktop.ViewModel.Interface;

    using ReactiveUI;

    public class DeskViewModel : ReactiveObject, IDeskViewModel, IRoutableViewModel
    {
        public string UrlPathSegment
        {
            get
            {
                return "Desk";
            }
        }

        public IScreen HostScreen { get; protected set; }
    }
}
