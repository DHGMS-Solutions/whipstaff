// --------------------------------------------------------------------------------------------------------------------
// <copyright file="About.xaml.cs" company="DHGMS Solutions">
//   Copyright 2012. Some Rights Reserved.
// </copyright>
// <summary>
//   Interaction logic for the about window
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.Whipstaff.View.Wndw
{
    using Dhgms.Whipstaff.ViewModel;

    using ReactiveUI;

    /// <summary>
    /// Interaction logic for the about window
    /// </summary>
    public partial class About
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="About"/> class.
        /// </summary>
        public About()
        {
            this.InitializeComponent();

            this.Bind(ViewModel, model => model.Copyright, about => about.Copyright.Content);
            this.Bind(ViewModel, model => model.Notice, about => about.Notice.Content);
            this.Bind(ViewModel, model => model.ProgramName, about => about.ProgramName.Content);
            this.Bind(ViewModel, model => model.ProgramVersion, about => about.ProgramVersion.Content);
        }
    }
}
