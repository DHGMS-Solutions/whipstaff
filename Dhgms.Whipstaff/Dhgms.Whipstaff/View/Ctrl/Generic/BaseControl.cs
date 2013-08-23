using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Dhgms.Whipstaff.View.Ctrl.Generic
{
    /// <summary>
    /// BaseView class for a control
    /// </summary>
    /// <typeparam name="TView">
    /// The type for the view
    /// </typeparam>
    /// <typeparam name="TViewModel">
    /// The type for the view model
    /// </typeparam>
    public class BaseControl<TView, TViewModel> : UserControl, IViewFor<TViewModel>
        where TView : class
        where TViewModel : class, IRoutableViewModel, new()
    {
        /// <summary>
        /// Dependency Property for the view model
        /// </summary>
// ReSharper disable StaticFieldInGenericType
        public static readonly DependencyProperty ViewModelProperty =
// ReSharper restore StaticFieldInGenericType
            DependencyProperty.Register("ViewModel", typeof(TViewModel), typeof(TView), new PropertyMetadata(null));

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseControl{TView,TViewModelInterface,TViewModel}"/> class.
        /// </summary>
        /// <param name="viewModel">
        /// The view model.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// No view model was passed.
        /// </exception>
        public BaseControl(TViewModel viewModel)
        {
            /*
            if (viewModel == null)
            {
                throw new ArgumentNullException("viewModel");
            }

            this.ViewModel = viewModel;
            this.DataContext = this.ViewModel;
             * */
        }

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
