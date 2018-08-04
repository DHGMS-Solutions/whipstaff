namespace Dhgms.Whipstaff.Showcase.Desktop.View
{
    using Dhgms.Whipstaff.Showcase.Desktop.ViewModel.Interface;

    /// <summary>
    /// This is here because of an issue in the WPF designer in Visual Studio 2012
    /// </summary>
    public partial class CommandQueue
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommandQueue"/> class.
        /// </summary>
        public CommandQueue(ICommandQueueViewModel viewModel)
            : base(viewModel)
        {
            this.InitializeComponent();
        }
    }

}
