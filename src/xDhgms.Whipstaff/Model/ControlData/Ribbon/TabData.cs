// -----------------------------------------------------------------------
// <copyright file="TabData.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Dhgms.Whipstaff.Model.ControlData.Ribbon
{
    using System;
    using System.Collections.ObjectModel;
    using System.ComponentModel;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class TabData : INotifyPropertyChanged
    {
        public TabData()
            : this(null)
        {
        }

        public TabData(string header)
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

        public string ContextualTabGroupHeader
        {
            get
            {
                return this._contextualTabGroupHeader;
            }

            set
            {
                if (this._contextualTabGroupHeader != value)
                {
                    this._contextualTabGroupHeader = value;
                    this.OnPropertyChanged(new PropertyChangedEventArgs("ContextualTabGroupHeader"));
                }
            }
        }
        private string _contextualTabGroupHeader;

        public bool IsSelected
        {
            get
            {
                return this._isSelected;
            }

            set
            {
                if (this._isSelected != value)
                {
                    this._isSelected = value;
                    this.OnPropertyChanged(new PropertyChangedEventArgs("IsSelected"));
                }
            }
        }
        private bool _isSelected;

        public ObservableCollection<GroupData> GroupDataCollection
        {
            get
            {
                if (this._groupDataCollection == null)
                {
                    Uri smallImage = new Uri("/RibbonWindowSample;component/Images/Paste_16x16.png", UriKind.Relative);
                    Uri largeImage = new Uri("/RibbonWindowSample;component/Images/Paste_32x32.png", UriKind.Relative);

                    this._groupDataCollection = new ObservableCollection<GroupData>();
                    for (int i = 0; i < ViewModelData.GroupCount; i++)
                    {
                        this._groupDataCollection.Add(new GroupData("Group " + i)
                        {
                            LargeImage = largeImage,
                            SmallImage = smallImage
                        });
                    }
                }
                return this._groupDataCollection;
            }
        }
        private ObservableCollection<GroupData> _groupDataCollection;

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
