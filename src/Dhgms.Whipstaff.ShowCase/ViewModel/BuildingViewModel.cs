namespace Dhgms.Whipstaff.ShowCase.ViewModel
{
    using System.Collections.Generic;
    using ReactiveUI;

    /// <summary>
    /// The building view model.
    /// </summary>
    public class BuildingViewModel : ReactiveObject, IBuildingViewModel, IRoutableViewModel
    {
        /// <summary>
        /// Name of the building.
        /// </summary>
        private string name;

        /// <summary>
        /// Collection of Floors
        /// </summary>
        private List<string> floors;

        public string UrlPathSegment
        {
            get
            {
                return "Building";
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
                this.RaiseAndSetIfChanged(ref this.name, value);
            }
        }

        /// <summary>
        /// Gets or sets the building floors
        /// </summary>
        public List<string> Floors
        {
            get
            {
                return this.floors;
            }

            set
            {
                this.RaiseAndSetIfChanged(ref this.floors, value);
            }
        }
    }
}
