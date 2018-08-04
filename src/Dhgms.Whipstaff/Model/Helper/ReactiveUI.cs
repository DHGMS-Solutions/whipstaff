using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.Whipstaff.Model.Helper
{
    using ReactiveUI;

    public static class ReactiveUiHelpers
    {
        public static Dhgms.Whipstaff.Model.ControlData.Button.ButtonItem EnsureButtonExists(
            ref Dhgms.Whipstaff.Model.ControlData.Button.ButtonItem backingField,
            string name,
            ReactiveCommand<object> command)
        {
            return backingField
                   ?? (backingField =
                       new Dhgms.Whipstaff.Model.ControlData.Button.ButtonItem { Name = name, Command = command });
        }

        public static Dhgms.Whipstaff.Model.ControlData.Ribbon.ButtonData EnsureRibbonButtonExists(
            ref Dhgms.Whipstaff.Model.ControlData.Ribbon.ButtonData backingField,
            string name,
            ReactiveCommand<object> command)
        {
            return backingField
                   ?? (backingField =
                       new Dhgms.Whipstaff.Model.ControlData.Ribbon.ButtonData { Label = name, Command = command });
        }

        public static ReactiveCommand<object> EnsureCommandExists(ref ReactiveCommand<object> backingField, IObservable<bool> canExecuteObservable, Action<object> subscriptionEvent)
        {
            if (backingField == null)
            {
                backingField = (canExecuteObservable != null) ? ReactiveCommand.Create(canExecuteObservable) : ReactiveCommand.Create();
                backingField.Subscribe(subscriptionEvent);
            }

            return backingField;
        }
    }
}
