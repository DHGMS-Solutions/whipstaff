namespace Dhgms.Whipstaff.Core.ViewModels
{
#if REACTIVESCREEN
    using Caliburn.Micro.ReactiveUI;
#endif

    using ReactiveUI;

    using Splat;
#if REACTIVESCREEN
    public class ViewModelBase<TInheritingClass> : ReactiveScreen, IRoutableViewModel, IFeatureUsageTracking
#else
    public class ViewModelBase<TInheritingClass> : ReactiveObject, IRoutableViewModel, IFeatureUsageTracking
#endif
        where TInheritingClass : ViewModelBase<TInheritingClass>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModelBase{TInheritingClass}"/> class.
        /// </summary>
        public ViewModelBase()
        {
            this.Logger = this.Log();
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
        protected IFullLogger Logger
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
            this.Logger.WarnException("Feature Exception", exception);
        }

        public void OnFeatureError()
        {
            this.Logger.Warn("Feature error");
        }
    }
}
