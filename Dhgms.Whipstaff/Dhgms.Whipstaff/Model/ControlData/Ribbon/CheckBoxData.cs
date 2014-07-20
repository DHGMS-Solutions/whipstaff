// -----------------------------------------------------------------------
// <copyright file="CheckBoxData.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Dhgms.Whipstaff.Model.ControlData.Ribbon
{
    using System.ComponentModel;

    using ReactiveUI;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class CheckBoxData : ControlData
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
