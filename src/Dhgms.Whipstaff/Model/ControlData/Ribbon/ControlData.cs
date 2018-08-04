// -----------------------------------------------------------------------
// <copyright file="RibbonControlData.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

using ReactiveUI;

namespace Dhgms.Whipstaff.Model.ControlData.Ribbon
{
    using System;
    using System.ComponentModel;
    using System.Windows.Input;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class ControlData : ReactiveObject, INotifyPropertyChanged
    {
        public string Label
        {
            get
            {
                return this._label;
            }

            set
            {
                this.RaiseAndSetIfChanged(ref this._label, value);
            }
        }
        private string _label;

        public Uri LargeImage
        {
            get
            {
                return this._largeImage;
            }

            set
            {
                this.RaiseAndSetIfChanged(ref this._largeImage, value);
            }
        }
        private Uri _largeImage;

        public Uri SmallImage
        {
            get
            {
                return this._smallImage;
            }

            set
            {
                this.RaiseAndSetIfChanged(ref this._smallImage, value);
            }
        }
        private Uri _smallImage;

        public string ToolTipTitle
        {
            get
            {
                return this._toolTipTitle;
            }

            set
            {
                this.RaiseAndSetIfChanged(ref this._toolTipTitle, value);
            }
        }
        private string _toolTipTitle;

        public string ToolTipDescription
        {
            get
            {
                return this._toolTipDescription;
            }

            set
            {
                this.RaiseAndSetIfChanged(ref this._toolTipDescription, value);
            }
        }
        private string _toolTipDescription;

        public Uri ToolTipImage
        {
            get
            {
                return this._toolTipImage;
            }

            set
            {
                this.RaiseAndSetIfChanged(ref this._toolTipImage, value);
            }
        }
        private Uri _toolTipImage;

        public string ToolTipFooterTitle
        {
            get
            {
                return this._toolTipFooterTitle;
            }

            set
            {
                this.RaiseAndSetIfChanged(ref this._toolTipFooterTitle, value);
            }
        }
        private string _toolTipFooterTitle;

        public string ToolTipFooterDescription
        {
            get
            {
                return this._toolTipFooterDescription;
            }

            set
            {
                this.RaiseAndSetIfChanged(ref this._toolTipFooterDescription, value);
            }
        }
        private string _toolTipFooterDescription;

        public Uri ToolTipFooterImage
        {
            get
            {
                return this._toolTipFooterImage;
            }

            set
            {
                this.RaiseAndSetIfChanged(ref this._toolTipFooterImage, value);
            }
        }
        private Uri _toolTipFooterImage;

        public ICommand Command
        {
            get
            {
                return this._command;
            }

            set
            {
                this.RaiseAndSetIfChanged(ref this._command, value);
            }
        }
        private ICommand _command;

        public string KeyTip
        {
            get
            {
                return this._keyTip;
            }

            set
            {
                this.RaiseAndSetIfChanged(ref this._keyTip, value);
            }
        }
        private string _keyTip;
    }
}
