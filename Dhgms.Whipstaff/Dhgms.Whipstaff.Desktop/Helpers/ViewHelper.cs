namespace Dhgms.Whipstaff.Desktop.Helpers
{
    using System;
    using System.Linq.Expressions;

    using ReactiveUI;

    public static class ViewHelper
    {
        public static void BindButton<TView, TViewModel, TProp, TControl>(
            this TView view,
            TViewModel viewModel,
            Expression<Func<TViewModel, TProp>> commandPropertyName,
            Expression<Func<TViewModel, string>> tooltipName,
            Expression<Func<TView, TControl>> controlName)
            where TView : class, IViewFor<TViewModel>
            where TViewModel : ReactiveObject
            where TProp : System.Windows.Input.ICommand
        {
            view.BindCommand(viewModel, commandPropertyName, controlName);
            //#warning todo tooltip
            //view.Bind(viewModel, tooltipName, controlName);
        }
    }
}
