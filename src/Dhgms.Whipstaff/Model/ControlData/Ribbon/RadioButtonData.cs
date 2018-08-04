// -----------------------------------------------------------------------
// <copyright file="RibbonButtonData.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

using ReactiveUI;

namespace Dhgms.Whipstaff.Model.ControlData.Ribbon
{
    using System.ComponentModel;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class RadioButtonData : ControlData
    {
        public bool IsChecked
        {
            get
            {
                return this._isChecked;
            }

            set
            {
                this.RaiseAndSetIfChanged(ref this._isChecked, value);
            }
        }
        private bool _isChecked;
    }
}
