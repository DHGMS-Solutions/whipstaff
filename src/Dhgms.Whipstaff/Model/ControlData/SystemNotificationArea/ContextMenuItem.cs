// -----------------------------------------------------------------------
// <copyright file="ContextMenuItem.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Dhgms.Whipstaff.Model.ControlData.SystemNotificationArea
{
    using ReactiveUI;

    /// <summary>
    /// Context Menu Item Control Data
    /// </summary>
    public class ContextMenuItem : ReactiveObject
    {
        /// <summary>
        /// command for the context menu item
        /// </summary>
        private ReactiveCommand<object> command;

        /// <summary>
        /// Label for the context menu item
        /// </summary>
        private string label;

        /// <summary>
        /// Tool tip for the context menu item
        /// </summary>
        private string toolTip;

        /// <summary>
        /// Gets or sets the label for the Context Menu Item
        /// </summary>
        public string Label
        {
            get
            {
                return this.label;
            }

            set
            {
                this.RaiseAndSetIfChanged(ref this.label, value);
            }
        }

        /// <summary>
        /// Gets or sets the Tool Tip for the Context Menu Item
        /// </summary>
        public string ToolTip
        {
            get
            {
                return this.toolTip;
            }

            set
            {
                this.RaiseAndSetIfChanged(ref this.toolTip, value);
            }
        }

        /// <summary>
        /// Gets or sets the command for the context menu item
        /// </summary>
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
