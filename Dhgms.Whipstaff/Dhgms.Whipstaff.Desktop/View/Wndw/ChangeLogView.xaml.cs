// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ChangeLog.xaml.cs" company="DHGMS Solutions">
//   Copyright 2012. Some Rights Reserved.
// </copyright>
// <summary>
//   Interaction logic for Change Log Window
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.Whipstaff.Desktop.View.Wndw
{
    using Dhgms.Whipstaff.Core.ViewModels;

    /// <summary>
    /// Interaction logic for Change Log Window
    /// </summary>
    public partial class ChangeLogView
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeLogView"/> class.
        /// </summary>
        public ChangeLogView(IChangeLogViewModel viewModel)
            : base(viewModel)
        {
            InitializeComponent();

            //this.Bind(ViewModel, model => model.Versions, control => control.Versions);
        }
    }
}
