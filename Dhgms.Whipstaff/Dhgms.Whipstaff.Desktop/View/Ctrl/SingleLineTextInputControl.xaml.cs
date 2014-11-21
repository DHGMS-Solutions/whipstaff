using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Dhgms.Whipstaff.View.Ctrl
{
    /// <summary>
    /// Interaction logic for SingleLineTextInputControl.xaml
    /// </summary>
    public partial class SingleLineTextInputControl
    {
        /// <summary>Initializes a new instance of the <see cref="SingleLineTextInputControl"/> class.</summary>
        public SingleLineTextInputControl()
        {
            InitializeComponent();
            this.ActualInput.TextChanged += this.ActualInputOnTextChanged;
            this.Unloaded += this.OnUnloaded;
        }

        /// <summary>The actual input on text changed.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="textChangedEventArgs">The text changed event args.</param>
        private void ActualInputOnTextChanged(object sender, TextChangedEventArgs textChangedEventArgs)
        {
            // TODO : Call Validate when text has stopped changing
            //this.ViewModel.ValidationIndicator = Model.Info.ValidationIndicator.Unknown;
        }

        /// <summary>The on unloaded.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="routedEventArgs">The routed event args.</param>
        private void OnUnloaded(object sender, RoutedEventArgs routedEventArgs)
        {
            this.ActualInput.TextChanged -= this.ActualInputOnTextChanged;
            this.Unloaded -= this.OnUnloaded;
        }
    }
}
