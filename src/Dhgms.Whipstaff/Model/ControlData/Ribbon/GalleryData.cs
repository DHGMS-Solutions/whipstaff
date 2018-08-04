﻿// -----------------------------------------------------------------------
// <copyright file="GalleryData.cs" company="">
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
    public class GalleryData : ControlData
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ObservableCollection<GalleryCategoryData> CategoryDataCollection
        {
            get
            {
                if (this._controlDataCollection == null)
                {
                    this._controlDataCollection = new ObservableCollection<GalleryCategoryData>();

                    Uri smallImage = new Uri("/RibbonWindowSample;component/Images/Paste_16x16.png", UriKind.Relative);
                    Uri largeImage = new Uri("/RibbonWindowSample;component/Images/Paste_32x32.png", UriKind.Relative);

                    for (int i = 0; i < ViewModelData.GalleryCategoryCount; i++)
                    {
                        this._controlDataCollection.Add(new GalleryCategoryData()
                        {
                            Label = "GalleryCategory " + i,
                            SmallImage = smallImage,
                            LargeImage = largeImage,
                            ToolTipTitle = "ToolTip Title",
                            ToolTipDescription = "ToolTip Description",
                            ToolTipImage = smallImage,
                            Command = ViewModelData.DefaultCommand
                        });
                    }
                }
                return this._controlDataCollection;
            }
        }
        private ObservableCollection<GalleryCategoryData> _controlDataCollection;

        public GalleryItemData SelectedItem
        {
            get { return this._selectedItem; }
            set
            {
                this.RaiseAndSetIfChanged(ref this._selectedItem, value);
            }
        }
        GalleryItemData _selectedItem;

        public bool CanUserFilter
        {
            get
            {
                return this._canUserFilter;
            }

            set
            {
                this.RaiseAndSetIfChanged(ref this._canUserFilter, value);
            }
        }

        private bool _canUserFilter;
    }

    public class GalleryData<T> : ControlData
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ObservableCollection<GalleryCategoryData<T>> CategoryDataCollection
        {
            get
            {
                if (this._controlDataCollection == null)
                {
                    this._controlDataCollection = new ObservableCollection<GalleryCategoryData<T>>();
                }
                return this._controlDataCollection;
            }
        }
        private ObservableCollection<GalleryCategoryData<T>> _controlDataCollection;

        public T SelectedItem
        {
            get { return this._selectedItem; }
            set
            {
                this.RaiseAndSetIfChanged(ref this._selectedItem, value);
            }
        }
        T _selectedItem;

        public bool CanUserFilter
        {
            get
            {
                return this._canUserFilter;
            }

            set
            {
                this.RaiseAndSetIfChanged(ref this._canUserFilter, value);
            }
        }

        private bool _canUserFilter;
    }
}
