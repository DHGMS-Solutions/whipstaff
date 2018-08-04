// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseView.cs" company="DHGMS Solutions">
//   Copyright 2012. Some Rights Reserved.
// </copyright>
// <summary>
//   BaseView class for a view
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.Whipstaff.View.Wndw.Generic
{
    using System;
    using System.Windows;

    using ReactiveUI;

    /// <summary>
    /// BaseView class for a view
    /// </summary>
    /// <typeparam name="TView">
    /// The type for the view
    /// </typeparam>
    /// <typeparam name="TViewModelInterface">
    /// The type for the view model interface
    /// </typeparam>
    /// <typeparam name="TViewModel">
    /// The type for the view model
    /// </typeparam>
    public class BaseView<TView, TViewModelInterface, TViewModel> : Window, IViewFor<TViewModelInterface>
        where TView : class
        where TViewModelInterface : class
        where TViewModel : class, TViewModelInterface, IRoutableViewModel, new()
    {
        /// <summary>
        /// Dependency Property for the view model
        /// </summary>
// ReSharper disable StaticFieldInGenericType
        public static readonly DependencyProperty ViewModelProperty =
// ReSharper restore StaticFieldInGenericType
            DependencyProperty.Register("ViewModel", typeof(TViewModelInterface), typeof(TView), new PropertyMetadata(null));

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseView{TView,TViewModelInterface,TViewModel}"/> class.
        /// </summary>
        public BaseView() : this(new TViewModel())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseView{TView,TViewModelInterface,TViewModel}"/> class.
        /// </summary>
        /// <param name="viewModel">
        /// The view model.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// No view model was passed.
        /// </exception>
        public BaseView(TViewModel viewModel)
        {
            if (viewModel == null)
            {
                throw new ArgumentNullException("viewModel");
            }

            this.ViewModel = new TViewModel();
            this.DataContext = this.ViewModel;
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
                this.ViewModel = (TViewModelInterface)value;
            }
        }

        /// <summary>
        /// Gets or sets the ViewModel corresponding to this specific View.
        /// </summary>
        public TViewModelInterface ViewModel
        {
            get
            {
                return (TViewModelInterface)this.GetValue(ViewModelProperty);
            }

            set
            {
                this.SetValue(ViewModelProperty, value);
            }
        }
    }
}
