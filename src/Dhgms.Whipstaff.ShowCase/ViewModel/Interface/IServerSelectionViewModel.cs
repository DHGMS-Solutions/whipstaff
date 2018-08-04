namespace Dhgms.Whipstaff.ShowCase.ViewModel
{
    using System.Collections.Generic;

    using Dhgms.Whipstaff.Model.Info;

    public interface IServerSelectionViewModel
    {
        IList<Server> Servers { get; set; }
    }
}
