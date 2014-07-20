using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.Whipstaff.ViewModel
{
    using ReactiveUI;

    using NLog;

    public class ViewModelBase<TInheritingClass> : ReactiveObject, IRoutableViewModel, IFeatureUsageTracking
        where TInheritingClass : ViewModelBase<TInheritingClass>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModelBase{TInheritingClass}"/> class.
        /// </summary>
        public ViewModelBase()
        {
            Logger = LogManager.GetLogger(typeof(TInheritingClass).Name);
        }

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

        /// <summary>
        /// Gets the logger instance.
        /// </summary>
        protected Logger Logger
        {
            get;
            private set;
        }

        public void OnFeatureStart()
        {
            this.Logger.Info("Feature Started.");
        }

        public void OnFeatureEnd()
        {
            this.Logger.Info("Feature Ended.");
        }

        public void OnFeatureException(System.Exception exception)
        {
            this.Logger.Warn("Feature Exception", exception);
        }

        public void OnFeatureError()
        {
        }

    }
}
