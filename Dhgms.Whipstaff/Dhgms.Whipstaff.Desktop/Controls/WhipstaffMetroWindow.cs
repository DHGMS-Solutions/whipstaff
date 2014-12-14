using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.Whipstaff.Desktop.Controls
{
    using System.Windows;

    using Dhgms.Whipstaff.Desktop.Helpers;

    using MahApps.Metro.Controls;

    using PerMonitorDPI;

    using ReactiveUI;

    public class WhipstaffMetroWindow<TView, TViewModel> : MetroWindow, IDesktopWindow, IViewFor<TViewModel>
        where TView : class
        where TViewModel : class
    {
        public WhipstaffMetroWindow(TViewModel viewModel)
        {
            if (viewModel == null)
            {
                throw new ArgumentNullException("viewModel");
            }

            DesktopWindowHelper.InitialiseWindow(this);
        }

        public PerMonitorDpiBehavior PerMonitorDpiBehavior { get; set; }

        /// <summary>
        /// Dependency Property for the view model
        /// </summary>
        // ReSharper disable StaticFieldInGenericType
        public static readonly DependencyProperty ViewModelProperty =
            // ReSharper restore StaticFieldInGenericType
            DependencyProperty.Register("ViewModel", typeof(TViewModel), typeof(TView), new PropertyMetadata(null));

        /// <summary>
        /// Gets or sets the view model.
        /// </summary>
        object IViewFor.ViewModel
        {
            get
            {
                return this.ViewModel;
            }

            set
            {
                this.ViewModel = (TViewModel)value;
            }
        }

        /// <summary>
        /// Gets or sets the ViewModel corresponding to this specific View.
        /// </summary>
        public TViewModel ViewModel
        {
            get
            {
                return (TViewModel)this.GetValue(ViewModelProperty);
            }

            set
            {
                this.SetValue(ViewModelProperty, value);
            }
        }

    }
}
