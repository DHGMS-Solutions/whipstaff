namespace Dhgms.Whipstaff.Desktop.View.Wndw
{
    using Dhgms.Whipstaff.Core.ViewModels;

    using ReactiveUI;

    /// <summary>
    /// Interaction logic for Keyboard shortcut window
    /// </summary>
    public partial class KeyboardView
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KeyboardView"/> class.
        /// </summary>
        public KeyboardView(IKeyboardViewModel viewModel)
            : base(viewModel)
        {
            InitializeComponent();

            this.Bind(ViewModel, model => model.KeyboardMappings, keyboard => keyboard.KeyboardMappings);
        }
    }
}
