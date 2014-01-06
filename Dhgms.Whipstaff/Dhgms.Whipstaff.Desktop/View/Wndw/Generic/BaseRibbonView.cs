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
    using System.Windows.Controls.Ribbon;

    /// <summary>
    /// BaseView class for a ribbon window
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
    public class BaseRibbonView<TView, TViewModelInterface, TViewModel> : RibbonWindow, IViewFor<TViewModelInterface>
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
