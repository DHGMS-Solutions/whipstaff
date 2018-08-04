namespace Dhgms.Whipstaff.Desktop.View.Wndw
{
    using System;
    using System.Windows.Media;

    using ReactiveUI;

    /// <summary>
    /// Interaction logic for MainRibbonWindow.xaml
    /// </summary>
    public partial class MainRibbonWindow
    {
        public MainRibbonWindow()
        {
            InitializeComponent();

            //this.QuickAccessEventLog.SmallImageSource = new WpfTools.ImageFromFont()
            //{
            //    Text = Dhgms.Whipstaff.Model.Info.FontAwesome.Stethoscope,
            //    FontFamily = new FontFamily("/Dhgms.Whipstaff;Component/Resource/Font/#FontAwesome"),
            //    Brush = System.Windows.Media.Brushes.Black
            //}.GetGlyph();

            //this.HelpButton.SmallImageSource = new WpfTools.ImageFromFont()
            //{
            //    Text = Dhgms.Whipstaff.Model.Info.FontAwesome.QuestionSign,
            //    FontFamily = new FontFamily("/Dhgms.Whipstaff;Component/Resource/Font/#FontAwesome"),
            //    Brush = System.Windows.Media.Brushes.Blue
            //}.GetGlyph();

            //this.QuickAccessShowKeyboardShortcuts.SmallImageSource = new WpfTools.ImageFromFont
            //    {
            //        Text = Dhgms.Whipstaff.Model.Info.FontAwesome.Keyboard,
            //        FontFamily = new FontFamily("/Dhgms.Whipstaff;Component/Resource/Font/#FontAwesome"),
            //        Brush = System.Windows.Media.Brushes.Green
            //    }.GetGlyph();

            //this.QuickAccessSearch.SmallImageSource = new WpfTools.ImageFromFont() 
            //{
            //    Text = Dhgms.Whipstaff.Model.Info.FontAwesome.Search,
            //    FontFamily= new FontFamily("/Dhgms.Whipstaff;Component/Resource/Font/#FontAwesome"),
            //    Brush = System.Windows.Media.Brushes.Black
            //}.GetGlyph();

            //this.QuickAccessOptions.SmallImageSource = new WpfTools.ImageFromFont()
            //{
            //    Text = Dhgms.Whipstaff.Model.Info.FontAwesome.Cogs,
            //    FontFamily = new FontFamily("/Dhgms.Whipstaff;Component/Resource/Font/#FontAwesome"),
            //    Brush = System.Windows.Media.Brushes.Black
            //}.GetGlyph();

            //// bind the commands
            //this.Bind(this.ViewModel, model => model.MainControl, control => control.MainControl.Content);
            //this.Bind(this.ViewModel, model => model.ShowEventLogCommand, control => control.QuickAccessEventLog.Command);
            //this.Bind(this.ViewModel, model => model.ShowKeyboardShortcutsCommand, control => control.QuickAccessShowKeyboardShortcuts.Command);
            //this.Bind(this.ViewModel, model => model.ShowOptionsCommand, control => control.QuickAccessOptions.Command);
            //this.Bind(this.ViewModel, model => model.ShowSearchCommand, control => control.QuickAccessSearch.Command);
            //this.Bind(this.ViewModel, model => model.ShowHelpCommand, control => control.HelpButton.Command);

            //// bind the opacity properties
            //// todo: check if there is a better way to do this
            //this.ObservableForProperty(x => x.ViewModel.CanShowKeyboardShortcuts).Subscribe(
            //    x => OnQuickAccessButtonEnabler(
            //        this.QuickAccessShowKeyboardShortcuts,
            //        x.Value,
            //        "View Keyboard Shortcuts",
            //        "No Keyboard Shortcuts defined"));
            //this.ObservableForProperty(x => x.ViewModel.CanShowEventLog).Subscribe(
            //    x => OnQuickAccessButtonEnabler(
            //        this.QuickAccessEventLog,
            //        x.Value,
            //        "View Event Long",
            //        "Event Log Unavailable"));
            //this.ObservableForProperty(x => x.ViewModel.CanShowOptions).Subscribe(
            //    x => OnQuickAccessButtonEnabler(
            //        this.QuickAccessOptions,
            //        x.Value,
            //        "View Options",
            //        "Options Unavailable"));
            //this.ObservableForProperty(x => x.ViewModel.CanShowSearch).Subscribe(
            //    x => OnQuickAccessButtonEnabler(
            //        this.QuickAccessSearch,
            //        x.Value,
            //        "View Search",
            //        "Search Unavailable"));
            //this.ObservableForProperty(x => x.ViewModel.CanShowHelp).Subscribe(
            //    x => OnQuickAccessButtonEnabler(
            //        this.HelpButton,
            //        x.Value,
            //        "View Help",
            //        "Help Unavailable"));
            //this.ObservableForProperty(x => x.ViewModel.CanShowFeedback).Subscribe(
            //    x => OnQuickAccessButtonEnabler(
            //        this.QuickAccessFeedback,
            //        x.Value,
            //        "View Feedback System",
            //        "Feedback System Unavailable"));
            //this.ObservableForProperty(x => x.ViewModel.CanShowNotifications).Subscribe(
            //    x => OnQuickAccessButtonEnabler(
            //        this.QuickAccessNotifications,
            //        x.Value,
            //        "View Notifications",
            //        "Notifications Unavailable"));
        }

        private double GetOpacity(bool p)
        {
            return p ? 1 : 0.2;
        }

        private void OnQuickAccessButtonEnabler(
            System.Windows.Controls.Ribbon.RibbonButton ribbonButton,
            bool enabled,
            string enabledTooltip,
            string disabledTooltip)
        {
            ribbonButton.Opacity = GetOpacity(enabled);
            ribbonButton.ToolTip = enabled ? enabledTooltip : disabledTooltip;
        }
    }
}
