using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.Whipstaff.ViewModel
{
    using ReactiveUI;

    public class Base : ReactiveObject, IRoutableViewModel, IFeatureUsageTracking
    {
        /// <summary>
        /// Gets or sets a string token representing the current ViewModel, such as 'login' or 'user'
        /// </summary>
        public string UrlPathSegment { get; protected set; }

        /// <summary>
        /// Gets the IScreen that this ViewModel is currently being shown in. This
        ///             is usually passed into the ViewModel in the Constructor and saved
        ///             as a ReadOnly Property.
        /// </summary>
        public IScreen HostScreen { get; private set; }

        public void OnFeatureStart()
        {
        }

        public void OnFeatureEnd()
        {
        }

        public void OnFeatureException()
        {
        }

        public void OnFeatureError()
        {
        }
    }
}
