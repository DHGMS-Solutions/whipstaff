using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.Whipstaff.Model.ControlData.StatusBar
{
    using System.ComponentModel;
    using System.Windows.Input;

    public class StatusBarItem
    {
        /// <summary>
        /// command for the context menu item
        /// </summary>
        private ICommand command;

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
        public ICommand Command
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
