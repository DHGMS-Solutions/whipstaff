namespace Dhgms.Whipstaff.Core.Model
{
    public class CommandLineArguments
    {
        public bool ResetUi { get; set; }

        public bool ShowSplashScreen { get; set; }

        public bool IsProtocolUrlCall { get; set; }

        public CommandLineArguments()
        {
            this.ShowSplashScreen = true;
        }

        public virtual void Parse(string args)
        {
            
        }
    }
}
