// -----------------------------------------------------------------------
// <copyright file="ContextualTabGroupData.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Dhgms.Whipstaff.Model.ControlData.Ribbon
{
    using System.Collections.ObjectModel;
    using System.ComponentModel;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class ContextualTabGroupData : INotifyPropertyChanged
    {
        public ContextualTabGroupData()
            : this(null)
        {
        }

        public ContextualTabGroupData(string header)
        {
            this.Header = header;
        }


        public string Header
        {
            get
            {
                return this._header;
            }

            set
            {
                if (this._header != value)
                {
                    this._header = value;
                    this.OnPropertyChanged(new PropertyChangedEventArgs("Header"));
                }
            }
        }
        private string _header;

        public bool IsVisible
        {
            get
            {
                return this._isVisible;
            }

            set
            {
                if (this._isVisible != value)
                {
                    this._isVisible = value;
                    this.OnPropertyChanged(new PropertyChangedEventArgs("IsVisible"));
                }
            }
        }
        private bool _isVisible;

        public ObservableCollection<TabData> TabDataCollection
        {
            get
            {
                if (this._tabDataCollection == null)
                {
                    this._tabDataCollection = new ObservableCollection<TabData>();
                }
                return this._tabDataCollection;
            }
        }
        private ObservableCollection<TabData> _tabDataCollection;

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, e);
            }
        }

        #endregion
    }
}
