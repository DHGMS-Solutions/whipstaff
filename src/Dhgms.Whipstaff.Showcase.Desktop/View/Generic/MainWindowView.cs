﻿namespace Dhgms.Whipstaff.Showcase.Desktop.View.Generic
{
    using Dhgms.Whipstaff.Desktop.Controls;
    using Dhgms.Whipstaff.Showcase.Desktop.ViewModel;
    using Dhgms.Whipstaff.Showcase.Desktop.ViewModel.Interface;

    /// <summary>
    /// Wrappers for the Generic Class. This is done because of a WPF Designer Issue in Visual Studio 2012.
    /// </summary>
    public class MainWindowView : WhipstaffMetroWindow<MainWindowView, IMainWindowViewModel>
    {
        public MainWindowView(IMainWindowViewModel viewModel)
            : base(viewModel)
        {
        }
    }
}
