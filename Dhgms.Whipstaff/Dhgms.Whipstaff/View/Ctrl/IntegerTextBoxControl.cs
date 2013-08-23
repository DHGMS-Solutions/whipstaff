using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Dhgms.Whipstaff.View.Ctrl
{
    public class IntegerTextBoxControl : View.Ctrl.Generic.BaseControl<IntegerTextBoxControl, ViewModel.IntegerTextBoxViewModel>
    {
        public IntegerTextBoxControl() : base(new ViewModel.IntegerTextBoxViewModel())
        {
            this.PreviewTextInput += OnPreviewTextInputEvent;
            this.Unloaded += OnUnloadedEvent;
        }

        private void OnPreviewTextInputEvent(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            char c = Convert.ToChar(e.Text);
            e.Handled = !Char.IsNumber(c);
            base.OnPreviewTextInput(e);
        }

        private void OnUnloadedEvent(object sender, System.Windows.RoutedEventArgs e)
        {
            this.PreviewTextInput -= OnPreviewTextInputEvent;
            this.Unloaded -= OnUnloadedEvent;
        }
    }
}
