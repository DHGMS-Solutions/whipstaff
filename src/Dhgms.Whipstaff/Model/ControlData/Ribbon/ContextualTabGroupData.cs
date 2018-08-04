// -----------------------------------------------------------------------
// <copyright file="ContextualTabGroupData.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

using ReactiveUI;

namespace Dhgms.Whipstaff.Model.ControlData.Ribbon
{
    using System.Collections.ObjectModel;
    using System.ComponentModel;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class ContextualTabGroupData : ReactiveObject
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
                this.RaiseAndSetIfChanged(ref this._header, value);
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
                this.RaiseAndSetIfChanged(ref this._isVisible, value);
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
    }
}
