namespace Dhgms.Whipstaff.ShowCase.Model.Helper
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Windows;
    using System.Linq;
    using System.Windows.Controls;
    using System.Windows.Documents;
    using System.Windows.Ink;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Animation;
    using System.Windows.Shapes;
    using System.Collections;
    using System.Collections.Specialized;

    using Dhgms.Whipstaff.ShowCase.View.Ctrl;

    /// <summary>
    /// Taken from http://www.scottlogic.co.uk/blog/colin/2010/11/using-a-grid-as-the-panel-for-an-itemscontrol/
    /// </summary>
    public class GridUtils
    {
        #region ItemsPerRow attached property

        /// <summary>
        /// Identifies the ItemsPerRow attached property. 
        /// </summary>
        public static readonly DependencyProperty ItemsPerRowProperty =
            DependencyProperty.RegisterAttached("ItemsPerRow", typeof(int), typeof(GridUtils),
                new PropertyMetadata(0, new PropertyChangedCallback(OnItemsPerRowPropertyChanged)));

        /// <summary>
        /// Gets the value of the ItemsPerRow property
        /// </summary>
        public static int GetItemsPerRow(DependencyObject d)
        {
            return (int)d.GetValue(ItemsPerRowProperty);
        }

        /// <summary>
        /// Sets the value of the ItemsPerRow property
        /// </summary>
        public static void SetItemsPerRow(DependencyObject d, int value)
        {
            d.SetValue(ItemsPerRowProperty, value);
        }

        /// <summary>
        /// Handles property changed event for the ItemsPerRow property, constructing
        /// the required ItemsPerRow elements on the grid which this property is attached to.
        /// </summary>
        private static void OnItemsPerRowPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Grid grid = d as Grid;
            int itemsPerRow = (int)e.NewValue;

            // construct the required row definitions
            grid.LayoutUpdated += (s, e2) =>
            {
                // iterate over any new content presenters (i.e. instances of our DataTemplte)
                // that have been added to the grid
                var presenters = grid.Children.OfType<ContentPresenter>().ToList();
                foreach (var presenter in presenters)
                {
                    // the child of each DataTemplate should be our 'phantom' panel
                    var phantom = VisualTreeHelper.GetChild(presenter, 0) as PhantomPanel;
                    if (phantom != null)
                    {

                        // remove each of the children of the phantom and add to the grid
                        foreach (FrameworkElement child in phantom.Children.Cast<FrameworkElement>().ToList())
                        {
                            phantom.Children.Remove(child);
                            grid.Children.Add(child);
                            // ensure the child maintains its original datacontext
                            child.DataContext = phantom.DataContext;
                        }

                        // remove the presenter (and phantom)
                        grid.Children.Remove(presenter);
                    }
                }

                var childCount = grid.Children.Count;
                int rowDifference = (childCount / itemsPerRow) - grid.RowDefinitions.Count;

                // if new items have been added, create the required grid rows
                // and assign the row index to each child
                if (rowDifference != 0)
                {
                    grid.RowDefinitions.Clear();
                    for (int row = 0; row < (childCount / itemsPerRow); row++)
                    {
                        grid.RowDefinitions.Add(new RowDefinition());
                    }

                    // set the row property for each chid
                    for (int i = 0; i < childCount; i++)
                    {
                        var child = grid.Children[i] as FrameworkElement;
                        Grid.SetRow(child, i / itemsPerRow);
                    }
                }
            };
        }

        #endregion


        /// <summary>
        /// Identified the ItemsSource attached property
        /// </summary>
        public static readonly DependencyProperty ItemsSourceProperty =
            DependencyProperty.RegisterAttached("ItemsSource", typeof(IEnumerable), typeof(GridUtils),
                new PropertyMetadata(null, new PropertyChangedCallback(OnItemsSourcePropertyChanged)));

        /// <summary>
        /// Gets the value of the ItemsSource property
        /// </summary>
        public static IEnumerable GetItemsSource(DependencyObject d)
        {
            return (IEnumerable)d.GetValue(ItemsSourceProperty);
        }

        /// <summary>
        /// Sets the value of the ItemsSource property
        /// </summary>
        public static void SetItemsSource(DependencyObject d, IEnumerable value)
        {
            d.SetValue(ItemsSourceProperty, value);
        }

        /// <summary>
        /// Handles property changed event for the ItemsSource property.
        /// </summary>
        private static void OnItemsSourcePropertyChanged(DependencyObject d,
          DependencyPropertyChangedEventArgs e)
        {
            ItemsControl control = d as ItemsControl;

            // set the ItemsSource of the ItemsControl that this property is attached to
            control.ItemsSource = e.NewValue as IEnumerable;

            INotifyCollectionChanged notifyCollection = e.NewValue as INotifyCollectionChanged;
            if (notifyCollection != null)
            {
                // if a collection changed event occurs, reset the ItemsControl's
                // ItemsSource, rebuilding the UI 
                notifyCollection.CollectionChanged += (s, e2) =>
                {
                    control.ItemsSource = null;
                    control.ItemsSource = e.NewValue as IEnumerable;
                };
            }
        }
    }
}
