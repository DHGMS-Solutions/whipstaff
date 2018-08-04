namespace Dhgms.Whipstaff.Model.ControlData.Button
{
    using ReactiveUI;

    public class ButtonItem : ReactiveObject
    {
        private string name;
        private ReactiveCommand<object> command;

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

        public ReactiveCommand<object> Command
        {
            get
            {
                return this.command;
            }

            set
            {
                this.RaiseAndSetIfChanged(ref this.command, value);
            }
        }
    }
}
