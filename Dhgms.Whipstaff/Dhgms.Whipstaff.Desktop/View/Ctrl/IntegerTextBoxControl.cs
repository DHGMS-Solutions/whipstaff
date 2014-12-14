//namespace Dhgms.Whipstaff.Desktop.View.Ctrl
//{
//    using System;

//    public class IntegerTextBoxControl : BaseControl<IntegerTextBoxControl, ViewModel.IntegerTextBoxViewModel>
//    {
//        /// <summary>Initializes a new instance of the <see cref="IntegerTextBoxControl"/> class.</summary>
//        public IntegerTextBoxControl()
//        {
//            this.PreviewTextInput += OnPreviewTextInputEvent;
//            this.Unloaded += this.OnUnloadedEvent;
//        }

//        /// <summary>The on preview text input event.</summary>
//        /// <param name="sender">The sender.</param>
//        /// <param name="e">The e.</param>
//        private static void OnPreviewTextInputEvent(object sender, System.Windows.Input.TextCompositionEventArgs e)
//        {
//            var c = Convert.ToChar(e.Text);
//            e.Handled = !char.IsNumber(c);
//        }

//        /// <summary>The on unloaded event.</summary>
//        /// <param name="sender">The sender.</param>
//        /// <param name="e">The e.</param>
//        private void OnUnloadedEvent(object sender, System.Windows.RoutedEventArgs e)
//        {
//            this.PreviewTextInput -= OnPreviewTextInputEvent;
//            this.Unloaded -= this.OnUnloadedEvent;
//        }
//    }
//}
