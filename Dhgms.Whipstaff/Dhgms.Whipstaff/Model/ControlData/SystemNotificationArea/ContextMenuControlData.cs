// -----------------------------------------------------------------------
// <copyright file="ContextMenuControlData.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

using ReactiveUI;

namespace Dhgms.Whipstaff.Model.ControlData.SystemNotificationArea
{
    using System.ComponentModel;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class ContextMenuControlData : ReactiveObject
    {
        /// <summary>
        /// Collection of items for the context menu
        /// </summary>
        private ContextMenuItem[] items;

        /// <summary>
        /// Gets or sets the collection of items for the context menu.
        /// </summary>
        public ContextMenuItem[] Items
        {
            get
            {
                return this.items;
            }

            set
            {
                this.RaiseAndSetIfChanged(ref this.items, value);
            }
        }
    }
}
