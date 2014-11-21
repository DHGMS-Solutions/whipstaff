// -----------------------------------------------------------------------
// <copyright file="TabData.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

using ReactiveUI;

namespace Dhgms.Whipstaff.Model.ControlData.Ribbon
{
    using System;
    using System.Collections.ObjectModel;
    using System.ComponentModel;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class TabData : ReactiveObject
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
                this.RaiseAndSetIfChanged(ref this._header, value);
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
                this.RaiseAndSetIfChanged(ref this._contextualTabGroupHeader, value);
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
                this.RaiseAndSetIfChanged(ref this._isSelected, value);
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
    }
}
