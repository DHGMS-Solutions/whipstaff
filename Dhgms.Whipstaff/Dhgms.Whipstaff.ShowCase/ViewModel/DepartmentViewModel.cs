namespace Dhgms.Whipstaff.ShowCase.ViewModel
{
    using ReactiveUI;
    using ReactiveUI.Routing;

    public class DepartmentViewModel : ReactiveObject, IDepartmentViewModel, IRoutableViewModel
    {
        private string name;

        public string UrlPathSegment
        {
            get
            {
                return "Department";
            }
        }

        public IScreen HostScreen { get; protected set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.RaiseAndSetIfChanged(x => x.Name, ref this.name, value);
            }
        }
    }
}
