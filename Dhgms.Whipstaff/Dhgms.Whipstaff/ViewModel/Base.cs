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

        protected static Dhgms.Whipstaff.Model.ControlData.Button.ButtonItem EnsureButtonExists(
            ref Dhgms.Whipstaff.Model.ControlData.Button.ButtonItem backingField,
            string name,
            ReactiveCommand command)
        {
            if (backingField == null)
            {
                backingField = new Dhgms.Whipstaff.Model.ControlData.Button.ButtonItem
                {
                    Name = name,
                    Command = command
                };
            }

            return backingField;
        }

        protected static Dhgms.Whipstaff.Model.ControlData.Ribbon.ButtonData EnsureRibbonButtonExists(
            ref Dhgms.Whipstaff.Model.ControlData.Ribbon.ButtonData backingField,
            string name,
            ReactiveCommand command)
        {
            if (backingField == null)
            {
                backingField = new Dhgms.Whipstaff.Model.ControlData.Ribbon.ButtonData
                {
                    Label = name,
                    Command = command
                };
            }

            return backingField;
        }

        protected static ReactiveCommand EnsureCommandExists(ref ReactiveCommand backingField, IObservable<bool> canExecuteObservable, Action<object> subscriptionEvent)
        {
            if (backingField == null)
            {

                backingField = new ReactiveCommand(canExecuteObservable);
                backingField.Subscribe(subscriptionEvent);
            }

            return backingField;
        }
    }
}
