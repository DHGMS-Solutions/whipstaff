// -----------------------------------------------------------------------
// <copyright file="CheckBoxData.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Dhgms.Whipstaff.Model.ControlData.Ribbon
{
    using System.ComponentModel;

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
                if (this._isChecked != value)
                {
                    this._isChecked = value;
                    this.OnPropertyChanged(new PropertyChangedEventArgs("IsChecked"));
                }
            }
        }
        private bool _isChecked;
    }
}
