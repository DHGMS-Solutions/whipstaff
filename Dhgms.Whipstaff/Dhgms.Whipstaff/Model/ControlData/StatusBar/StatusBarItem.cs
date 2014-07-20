using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;

namespace Dhgms.Whipstaff.Model.ControlData.StatusBar
{
    using System.ComponentModel;
    using System.Windows.Input;

    public class StatusBarItem : ReactiveObject
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
        public ICommand Command
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
