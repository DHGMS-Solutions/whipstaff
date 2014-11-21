namespace Dhgms.Whipstaff.ViewModel
{
    /// <summary>
    /// Interface for the Logging Console View Model
    /// </summary>
    interface ILoggingConsoleViewModel
    {
        bool CanShowErrors { get; set; }

        bool CanShowWarning { get; set; }

        bool CanShowDebug { get; set; }

        bool CanShowInformation { get; set; }

        bool ShowErrors { get; set; }

        bool ShowWarning { get; set; }

        bool ShowDebug { get; set; }

        bool ShowInformation { get; set; }
    }
}
