// -----------------------------------------------------------------------
// <copyright file="RibbonControlData.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Dhgms.Whipstaff.Model.ControlData.Ribbon
{
    using System;
    using System.ComponentModel;
    using System.Windows.Input;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class ControlData : INotifyPropertyChanged
    {
        public string Label
        {
            get
            {
                return this._label;
            }

            set
            {
                if (this._label != value)
                {
                    this._label = value;
                    this.OnPropertyChanged(new PropertyChangedEventArgs("Label"));
                }
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
                if (this._largeImage != value)
                {
                    this._largeImage = value;
                    this.OnPropertyChanged(new PropertyChangedEventArgs("LargeImage"));
                }
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
                if (this._smallImage != value)
                {
                    this._smallImage = value;
                    this.OnPropertyChanged(new PropertyChangedEventArgs("SmallImage"));
                }
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
                if (this._toolTipTitle != value)
                {
                    this._toolTipTitle = value;
                    this.OnPropertyChanged(new PropertyChangedEventArgs("ToolTipTitle"));
                }
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
                if (this._toolTipDescription != value)
                {
                    this._toolTipDescription = value;
                    this.OnPropertyChanged(new PropertyChangedEventArgs("ToolTipDescription"));
                }
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
                if (this._toolTipImage != value)
                {
                    this._toolTipImage = value;
                    this.OnPropertyChanged(new PropertyChangedEventArgs("ToolTipImage"));
                }
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
                if (this._toolTipFooterTitle != value)
                {
                    this._toolTipFooterTitle = value;
                    this.OnPropertyChanged(new PropertyChangedEventArgs("ToolTipFooterTitle"));
                }
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
                if (this._toolTipFooterDescription != value)
                {
                    this._toolTipFooterDescription = value;
                    this.OnPropertyChanged(new PropertyChangedEventArgs("ToolTipFooterDescription"));
                }
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
                if (this._toolTipFooterImage != value)
                {
                    this._toolTipFooterImage = value;
                    this.OnPropertyChanged(new PropertyChangedEventArgs("ToolTipFooterImage"));
                }
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
                if (this._command != value)
                {
                    this._command = value;
                    this.OnPropertyChanged(new PropertyChangedEventArgs("Command"));
                }
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
                if (this._keyTip != value)
                {
                    this._keyTip = value;
                    this.OnPropertyChanged(new PropertyChangedEventArgs("KeyTip"));
                }
            }
        }
        private string _keyTip;

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, e);
            }
        }

        #endregion
    }
}
