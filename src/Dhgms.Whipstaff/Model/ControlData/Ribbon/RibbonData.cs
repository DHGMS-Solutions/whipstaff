// -----------------------------------------------------------------------
// <copyright file="RibbonData.cs" company="">
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
    public class RibbonData : ReactiveObject
    {
        public ObservableCollection<TabData> TabDataCollection
        {
            get
            {
                if (this._tabDataCollection == null)
                {
                    this._tabDataCollection = new ObservableCollection<TabData>();
                    for (int i = ViewModelData.TabCount, j = ViewModelData.ContextualTabGroupCount; i > 0; i--, j--)
                    {
                        if (j > 0)
                        {
                            string contextualTabGroupHeader = this.ContextualTabGroupDataCollection[j - 1].Header;
                            this._tabDataCollection.Insert(0, new TabData("Tab " + i) { ContextualTabGroupHeader = contextualTabGroupHeader });
                        }
                        else
                        {
                            this._tabDataCollection.Insert(0, new TabData("Tab " + i));
                        }
                    }
                }
                return this._tabDataCollection;
            }
        }
        private ObservableCollection<TabData> _tabDataCollection;

        public ObservableCollection<ContextualTabGroupData> ContextualTabGroupDataCollection
        {
            get
            {
                if (this._contextualTabGroupDataCollection == null)
                {
                    this._contextualTabGroupDataCollection = new ObservableCollection<ContextualTabGroupData>();
                    for (int i = 0; i < ViewModelData.ContextualTabGroupCount; i++)
                    {
                        this._contextualTabGroupDataCollection.Add(new ContextualTabGroupData("Grp " + i) { IsVisible = true });
                    }
                }
                return this._contextualTabGroupDataCollection;
            }
        }
        private ObservableCollection<ContextualTabGroupData> _contextualTabGroupDataCollection;

        public MenuButtonData ApplicationMenuData
        {
            get
            {
                if (this._applicationMenuData == null)
                {
                    Uri smallImage = new Uri("/RibbonWindowSample;component/Images/Paste_16x16.png", UriKind.Relative);
                    this._applicationMenuData = new MenuButtonData(true)
                    {
                        Label = "AppMenu ",
                        SmallImage = smallImage,
                        ToolTipTitle = "ToolTip Title",
                        ToolTipDescription = "ToolTip Description",
                        ToolTipImage = smallImage
                    };
                }
                return this._applicationMenuData;
            }
        }
        private MenuButtonData _applicationMenuData;
    }
}
