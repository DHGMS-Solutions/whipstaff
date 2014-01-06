using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Dhgms.Whipstaff.View.Wndw
{
    using ReactiveUI;
    using System.Windows.Controls.Ribbon.Primitives;

    /// <summary>
    /// Interaction logic for MainRibbonWindow.xaml
    /// </summary>
    public partial class MainRibbonWindow
    {
        public MainRibbonWindow()
        {
            this.ViewModel = ((Controller.Base)System.Windows.Application.Current).MainWindowViewModel;
            InitializeComponent();

            this.QuickAccessEventLog.SmallImageSource = new WpfTools.ImageFromFont()
            {
                Text = Dhgms.Whipstaff.Model.Info.FontAwesome.Stethoscope,
                FontFamily = new FontFamily("/Dhgms.Whipstaff;Component/Resource/Font/#FontAwesome"),
                Brush = System.Windows.Media.Brushes.Black
            }.GetGlyph();

            this.QuickAccessHelp.SmallImageSource = new WpfTools.ImageFromFont()
            {
                Text = Dhgms.Whipstaff.Model.Info.FontAwesome.QuestionSign,
                FontFamily = new FontFamily("/Dhgms.Whipstaff;Component/Resource/Font/#FontAwesome"),
                Brush = System.Windows.Media.Brushes.Blue
            }.GetGlyph();

            this.QuickAccessShowKeyboardShortcuts.SmallImageSource = new WpfTools.ImageFromFont
                {
                    Text = Dhgms.Whipstaff.Model.Info.FontAwesome.Keyboard,
                    FontFamily = new FontFamily("/Dhgms.Whipstaff;Component/Resource/Font/#FontAwesome"),
                    Brush = System.Windows.Media.Brushes.Green
                }.GetGlyph();

            this.QuickAccessSearch.SmallImageSource = new WpfTools.ImageFromFont() 
            {
                Text = Dhgms.Whipstaff.Model.Info.FontAwesome.Search,
                FontFamily= new FontFamily("/Dhgms.Whipstaff;Component/Resource/Font/#FontAwesome"),
                Brush=System.Windows.Media.Brushes.Black
            }.GetGlyph();

            this.QuickAccessOptions.SmallImageSource = new WpfTools.ImageFromFont()
            {
                Text = Dhgms.Whipstaff.Model.Info.FontAwesome.Cogs,
                FontFamily = new FontFamily("/Dhgms.Whipstaff;Component/Resource/Font/#FontAwesome"),
                Brush = System.Windows.Media.Brushes.Black
            }.GetGlyph();

            this.Bind(this.ViewModel, model => model.MainControl, control => control.MainControl.Content);
            this.Bind(this.ViewModel, model => model.ShowEventLogCommand, control => control.QuickAccessEventLog.Command);
            this.Bind(this.ViewModel, model => model.ShowHelpCommand, control => control.QuickAccessHelp.Command);
            this.Bind(this.ViewModel, model => model.ShowKeyboardShortcutsCommand, control => control.QuickAccessShowKeyboardShortcuts.Command);
            this.Bind(this.ViewModel, model => model.ShowOptionsCommand, control => control.QuickAccessOptions.Command);
            this.Bind(this.ViewModel, model => model.ShowSearchCommand, control => control.QuickAccessSearch.Command);
        }
    }
}
