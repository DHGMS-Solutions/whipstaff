// -----------------------------------------------------------------------
// <copyright file="TextBoxData.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Dhgms.Whipstaff.Model.ControlData.Ribbon
{
    using System.ComponentModel;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class TextBoxData : ControlData
    {
        public string Text
        {
            get
            {
                return this._text;
            }

            set
            {
                if (this._text != value)
                {
                    this._text = value;
                    this.OnPropertyChanged(new PropertyChangedEventArgs("Text"));
                }
            }
        }
        private string _text;
    }
}
