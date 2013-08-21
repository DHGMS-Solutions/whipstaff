// -----------------------------------------------------------------------
// <copyright file="MenuButtonData.cs" company="">
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
    public class MenuButtonData : ControlData
    {
        public MenuButtonData()
            : this(false)
        {
        }

        public MenuButtonData(bool isApplicationMenu)
        {
            this._isApplicationMenu = isApplicationMenu;
        }

        public bool IsVerticallyResizable
        {
            get
            {
                return this._isVerticallyResizable;
            }

            set
            {
                if (this._isVerticallyResizable != value)
                {
                    this._isVerticallyResizable = value;
                    this.OnPropertyChanged(new PropertyChangedEventArgs("IsVerticallyResizable"));
                }
            }
        }

        public bool IsHorizontallyResizable
        {
            get
            {
                return this._isHorizontallyResizable;
            }

            set
            {
                if (this._isHorizontallyResizable != value)
                {
                    this._isHorizontallyResizable = value;
                    this.OnPropertyChanged(new PropertyChangedEventArgs("IsHorizontallyResizable"));
                }
            }
        }

        private bool _isVerticallyResizable, _isHorizontallyResizable;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ObservableCollection<ControlData> ControlDataCollection
        {
            get
            {
                if (this._controlDataCollection == null)
                {
                    this._controlDataCollection = new ObservableCollection<ControlData>();

                    if (this._nestingDepth <= ViewModelData.MenuItemNestingCount)
                    {
                        this._nestingDepth++;

                        Uri smallImage = null;// new Uri("/RibbonWindowSample;component/Images/Paste_16x16.png", UriKind.Relative);
                        Uri largeImage = null;// new Uri("/RibbonWindowSample;component/Images/Paste_32x32.png", UriKind.Relative);

                        for (int i = 0; i < ViewModelData.GalleryCount; i++)
                        {
                            GalleryData galleryData = new GalleryData()
                            {
                                Label = "Gallery " + i,
                                SmallImage = smallImage,
                                LargeImage = largeImage,
                                ToolTipTitle = "ToolTip Title",
                                ToolTipDescription = "ToolTip Description",
                                ToolTipImage = smallImage,
                                Command = ViewModelData.DefaultCommand
                            };
                            galleryData.SelectedItem = galleryData.CategoryDataCollection[0].GalleryItemDataCollection[ViewModelData.GalleryItemCount - 1];

                            this._controlDataCollection.Add(galleryData);
                        }
                        for (int i = 0; i < ViewModelData.MenuItemCount; i++)
                        {
                            MenuItemData menuItemData = this._isApplicationMenu ?
                                new ApplicationMenuItemData(true) :
                                new MenuItemData(false);
                            menuItemData.Label = "MenuItem " + i;
                            menuItemData.SmallImage = smallImage;
                            menuItemData.LargeImage = largeImage;
                            menuItemData.ToolTipTitle = "ToolTip Title";
                            menuItemData.ToolTipDescription = "ToolTip Description";
                            menuItemData.ToolTipImage = smallImage;
                            menuItemData.Command = ViewModelData.DefaultCommand;
                            menuItemData._nestingDepth = this._nestingDepth;

                            this._controlDataCollection.Add(menuItemData);
                        }

                        this._controlDataCollection.Add(new SeparatorData());

                        for (int i = 0; i < ViewModelData.SplitMenuItemCount; i++)
                        {
                            SplitMenuItemData splitMenuItemData = this._isApplicationMenu ?
                                new ApplicationSplitMenuItemData(true) :
                                new SplitMenuItemData(false);
                            splitMenuItemData.Label = "SplitMenuItem " + i;
                            splitMenuItemData.SmallImage = smallImage;
                            splitMenuItemData.LargeImage = largeImage;
                            splitMenuItemData.ToolTipTitle = "ToolTip Title";
                            splitMenuItemData.ToolTipDescription = "ToolTip Description";
                            splitMenuItemData.ToolTipImage = smallImage;
                            splitMenuItemData.Command = ViewModelData.DefaultCommand;
                            splitMenuItemData._nestingDepth = this._nestingDepth;
                            splitMenuItemData.IsCheckable = true;

                            this._controlDataCollection.Add(splitMenuItemData);
                        }
                    }
                }
                return this._controlDataCollection;
            }
        }
        private ObservableCollection<ControlData> _controlDataCollection;
        private int _nestingDepth;
        private bool _isApplicationMenu;
    }
}
