using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.Whipstaff.ShowCase.ViewModel.Interface
{
    interface ICustomerViewModel
    {
        string Forename { get; set; }

        string Surname { get; set; }

        DateTime DateOfBirth { get; set; }

        IList<string> Addresses { get; set; }

        IList<string> Emails { get; set; }

        IList<string> PhoneNumbers { get; set; }
    }
}
