// -----------------------------------------------------------------------
// <copyright file="TextBoxData.cs" company="">
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
                this.RaiseAndSetIfChanged(ref this._text, value);
            }
        }
        private string _text;
    }
}
