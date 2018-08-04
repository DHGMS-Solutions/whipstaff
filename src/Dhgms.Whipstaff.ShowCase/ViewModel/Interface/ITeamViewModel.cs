namespace Dhgms.Whipstaff.ShowCase.ViewModel
{
    using System.Collections.Generic;

    public interface ITeamViewModel
    {
        string Name { get; set; }

        IEmployeeViewModel Leader { get; set; }

        IList<IEmployeeViewModel> Members { get; set; }
    }
}
