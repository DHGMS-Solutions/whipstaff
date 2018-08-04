// -----------------------------------------------------------------------
// <copyright file="SplitButtonData.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Dhgms.Whipstaff.Model.ControlData.Ribbon
{
    using System.ComponentModel;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class SplitButtonData : MenuButtonData
    {
        public SplitButtonData()
            : this(false)
        {
        }

        public SplitButtonData(bool isApplicationMenu)
            : base(isApplicationMenu)
        {
        }

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

        public bool IsCheckable
        {
            get
            {
                return this._isCheckable;
            }

            set
            {
                if (this._isCheckable != value)
                {
                    this._isCheckable = value;
                    this.OnPropertyChanged(new PropertyChangedEventArgs("IsCheckable"));
                }
            }
        }
        private bool _isCheckable;

        public ButtonData DropDownButtonData
        {
            get
            {
                if (this._dropDownButtonData == null)
                {
                    this._dropDownButtonData = new ButtonData();
                }

                return this._dropDownButtonData;
            }
        }
        private ButtonData _dropDownButtonData;
    }
}
