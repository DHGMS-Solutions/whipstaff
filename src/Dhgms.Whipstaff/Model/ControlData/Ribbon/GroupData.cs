// -----------------------------------------------------------------------
// <copyright file="GroupData.cs" company="">
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
    public class GroupData : ControlData
    {
        public GroupData(string header)
        {
            this.Label = header;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ObservableCollection<ControlData> ControlDataCollection
        {
            get
            {
                if (this._controlDataCollection == null)
                {
                    this._controlDataCollection = new ObservableCollection<ControlData>();

                    Uri smallImage = new Uri("/RibbonWindowSample;component/Images/Paste_16x16.png", UriKind.Relative);
                    Uri largeImage = new Uri("/RibbonWindowSample;component/Images/Paste_32x32.png", UriKind.Relative);

                    for (int i = 0; i < ViewModelData.ButtonCount; i++)
                    {
                        this._controlDataCollection.Add(new ButtonData()
                        {
                            Label = "Button " + i,
                            SmallImage = smallImage,
                            LargeImage = largeImage,
                            ToolTipTitle = "ToolTip Title",
                            ToolTipDescription = "ToolTip Description",
                            ToolTipImage = smallImage,
                            Command = ViewModelData.DefaultCommand
                        });
                    }
                    for (int i = 0; i < ViewModelData.ToggleButtonCount; i++)
                    {
                        this._controlDataCollection.Add(new ToggleButtonData()
                        {
                            Label = "ToggleButton " + i,
                            SmallImage = smallImage,
                            LargeImage = largeImage,
                            ToolTipTitle = "ToolTip Title",
                            ToolTipDescription = "ToolTip Description",
                            ToolTipImage = smallImage,
                            Command = ViewModelData.DefaultCommand
                        });
                    }
                    for (int i = 0; i < ViewModelData.RadioButtonCount; i++)
                    {
                        this._controlDataCollection.Add(new RadioButtonData()
                        {
                            Label = "RadioButton " + i,
                            SmallImage = smallImage,
                            LargeImage = largeImage,
                            ToolTipTitle = "ToolTip Title",
                            ToolTipDescription = "ToolTip Description",
                            ToolTipImage = smallImage,
                            Command = ViewModelData.DefaultCommand
                        });
                    }
                    for (int i = 0; i < ViewModelData.CheckBoxCount; i++)
                    {
                        this._controlDataCollection.Add(new CheckBoxData()
                        {
                            Label = "CheckBox " + i,
                            SmallImage = smallImage,
                            LargeImage = largeImage,
                            ToolTipTitle = "ToolTip Title",
                            ToolTipDescription = "ToolTip Description",
                            ToolTipImage = smallImage,
                            Command = ViewModelData.DefaultCommand
                        });
                    }
                    for (int i = 0; i < ViewModelData.TextBoxCount; i++)
                    {
                        this._controlDataCollection.Add(new TextBoxData()
                        {
                            Label = "TextBox " + i,
                            SmallImage = smallImage,
                            LargeImage = largeImage,
                            ToolTipTitle = "ToolTip Title",
                            ToolTipDescription = "ToolTip Description",
                            ToolTipImage = smallImage,
                            Command = ViewModelData.DefaultCommand
                        });
                    }
                    for (int i = 0; i < ViewModelData.MenuButtonCount; i++)
                    {
                        this._controlDataCollection.Add(new MenuButtonData()
                        {
                            Label = "MenuButton " + i,
                            SmallImage = smallImage,
                            LargeImage = largeImage,
                            ToolTipTitle = "ToolTip Title",
                            ToolTipDescription = "ToolTip Description",
                            ToolTipImage = smallImage,
                            Command = ViewModelData.DefaultCommand
                        });
                    }
                    for (int i = 0; i < ViewModelData.SplitButtonCount; i++)
                    {
                        this._controlDataCollection.Add(new SplitButtonData()
                        {
                            Label = "SplitButton " + i,
                            SmallImage = smallImage,
                            LargeImage = largeImage,
                            ToolTipTitle = "ToolTip Title",
                            ToolTipDescription = "ToolTip Description",
                            ToolTipImage = smallImage,
                            Command = ViewModelData.DefaultCommand,
                            IsCheckable = true
                        });
                    }
                    for (int i = 0; i < ViewModelData.ComboBoxCount; i++)
                    {
                        this._controlDataCollection.Add(new ComboBoxData()
                        {
                            Label = "ComboBox " + i,
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
        private ObservableCollection<ControlData> _controlDataCollection;

    }
}
