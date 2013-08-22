// -----------------------------------------------------------------------
// <copyright file="ContextMenuItem.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Dhgms.Whipstaff.Model.ControlData.SystemNotificationArea
{
    using System.ComponentModel;
    using System.Windows.Input;

    using ReactiveUI;

    /// <summary>
    /// Context Menu Item Control Data
    /// </summary>
    public class ContextMenuItem
    {
        /// <summary>
        /// command for the context menu item
        /// </summary>
        private ReactiveCommand command;

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
                if (this.label == value)
                {
                    return;
                }

                this.label = value;
                this.OnPropertyChanged(new PropertyChangedEventArgs("Label"));
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
                if (this.toolTip == value)
                {
                    return;
                }

                this.toolTip = value;
                this.OnPropertyChanged(new PropertyChangedEventArgs("ToolTip"));
            }
        }

        /// <summary>
        /// Gets or sets the command for the context menu item
        /// </summary>
        public ReactiveCommand Command
        {
            get
            {
                return this.command;
            }

            set
            {
                if (this.command == value)
                {
                    return;
                }

                this.command = value;
                this.OnPropertyChanged(new PropertyChangedEventArgs("Command"));
            }
        }

        #region INotifyPropertyChanged Members

        /// <summary>
        /// Property Changed Event Handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// On Property Changed Event
        /// </summary>
        /// <param name="e">
        /// Event Arguments
        /// </param>
        protected void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, e);
            }
        }

        #endregion
    }
}
