// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ChangeLog.xaml.cs" company="DHGMS Solutions">
//   Copyright 2012. Some Rights Reserved.
// </copyright>
// <summary>
//   Interaction logic for Change Log Window
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.Whipstaff.View.Wndw
{
    using ReactiveUI;

    /// <summary>
    /// Interaction logic for Change Log Window
    /// </summary>
    public partial class ChangeLog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeLog"/> class.
        /// </summary>
        public ChangeLog()
        {
            InitializeComponent();

            //this.Bind(ViewModel, model => model.Versions, control => control.Versions);
        }
    }
}
