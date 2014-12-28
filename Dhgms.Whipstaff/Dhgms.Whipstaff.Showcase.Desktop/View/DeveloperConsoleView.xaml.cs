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
using System.Windows.Shapes;

namespace Dhgms.Whipstaff.Showcase.Desktop.View
{
    using Dhgms.Whipstaff.Showcase.Desktop.ViewModel;

    /// <summary>
    /// Interaction logic for DeveloperConsoleView.xaml
    /// </summary>
    public partial class DeveloperConsoleView
    {
        public DeveloperConsoleView(DeveloperConsoleViewModel viewModel)
            : base(viewModel)
        {
            InitializeComponent();
        }
    }
}
