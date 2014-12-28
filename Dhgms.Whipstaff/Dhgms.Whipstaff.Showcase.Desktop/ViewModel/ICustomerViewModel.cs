namespace Dhgms.Whipstaff.Showcase.Desktop.ViewModel.Interface
{
    using System;
    using System.Collections.Generic;

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
