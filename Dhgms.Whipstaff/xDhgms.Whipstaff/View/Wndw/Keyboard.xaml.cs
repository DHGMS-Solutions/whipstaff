using System.Windows;

namespace Dhgms.Whipstaff.View.Wndw
{
    using ReactiveUI;

    /// <summary>
    /// Interaction logic for Keyboard shortcut window
    /// </summary>
    public partial class Keyboard
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Keyboard"/> class.
        /// </summary>
        public Keyboard()
        {
            InitializeComponent();

            this.Bind(ViewModel, model => model.KeyboardMappings, keyboard => keyboard.KeyboardMappings);
        }
    }
}
