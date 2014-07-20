namespace Dhgms.Whipstaff.ViewModel
{
    using System.Windows.Controls;
    using System.Windows.Input;

    /// <summary>
    /// Interface for the System Notification Area View Model
    /// </summary>
    public interface ISystemNotificationAreaViewModel
    {
        /// <summary>
        /// Gets the Control Data for the Context Menu.
        /// </summary>
        ContextMenu ContextMenu { get; set; }

        /// <summary>
        /// Gets or sets the filename for the icon.
        /// </summary>
        string IconFileUri { get; }

        string ToolTipText { get; }

        void OnAllMainWindowsClosed();

        ICommand DoubleClick { get; }
    }
}
