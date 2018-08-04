// -----------------------------------------------------------------------
// <copyright file="GalleryCategoryData.cs" company="">
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
    public class GalleryCategoryData : ControlData
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ObservableCollection<GalleryItemData> GalleryItemDataCollection
        {
            get
            {
                if (this._controlDataCollection == null)
                {
                    this._controlDataCollection = new ObservableCollection<GalleryItemData>();

                    Uri smallImage = new Uri("/RibbonWindowSample;component/Images/Paste_16x16.png", UriKind.Relative);
                    Uri largeImage = new Uri("/RibbonWindowSample;component/Images/Paste_32x32.png", UriKind.Relative);

                    for (int i = 0; i < ViewModelData.GalleryItemCount; i++)
                    {
                        this._controlDataCollection.Add(new GalleryItemData()
                        {
                            Label = "GalleryItem " + i,
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
        private ObservableCollection<GalleryItemData> _controlDataCollection;
    }

    public class GalleryCategoryData<T> : ControlData
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ObservableCollection<T> GalleryItemDataCollection
        {
            get
            {
                if (this._controlDataCollection == null)
                {
                    this._controlDataCollection = new ObservableCollection<T>();
                }
                return this._controlDataCollection;
            }
        }
        private ObservableCollection<T> _controlDataCollection;
    }
}
