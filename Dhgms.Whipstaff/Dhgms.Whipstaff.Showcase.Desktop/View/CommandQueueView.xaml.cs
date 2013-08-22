namespace Dhgms.Whipstaff.ShowCase.View
{
    using System;
    using System.Reactive.Disposables;
    using System.Reactive.Linq;
    using System.Windows;

    using ReactiveUI;

    /// <summary>
    /// This is here because of an issue in the WPF designer in Visual Studio 2012
    /// </summary>
    public partial class CommandQueue
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommandQueue"/> class.
        /// </summary>
        public CommandQueue()
        {
            this.InitializeComponent();
        }
    }

}
