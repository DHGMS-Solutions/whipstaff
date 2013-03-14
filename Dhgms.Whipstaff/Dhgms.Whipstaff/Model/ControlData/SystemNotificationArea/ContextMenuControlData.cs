// -----------------------------------------------------------------------
// <copyright file="ContextMenuControlData.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Dhgms.Whipstaff.Model.ControlData.SystemNotificationArea
{
    using System.ComponentModel;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class ContextMenuControlData
    {
        /// <summary>
        /// Collection of items for the context menu
        /// </summary>
        private ContextMenuItem[] items;

        /// <summary>
        /// Property Changed Event Handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

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
                if (this.items == value)
                {
                    return;
                }

                this.items = value;
                this.OnPropertyChanged(new PropertyChangedEventArgs("Label"));
            }
        }

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
    }
}
