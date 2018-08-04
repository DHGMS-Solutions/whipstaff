﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Dhgms.Whipstaff.ShowCase
{
    using ReactiveUI;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow //: Window, IViewFor<Dhgms.Whipstaff.ShowCase.ViewModel.MainWindowViewModel>
    {
        public MainWindow()
        {
            this.InitializeComponent();
            this.DataContext = new Dhgms.Whipstaff.ShowCase.ViewModel.MainWindowViewModel();
        }
    }
}
