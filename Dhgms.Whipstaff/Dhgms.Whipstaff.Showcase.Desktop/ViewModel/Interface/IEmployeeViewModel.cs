namespace Dhgms.Whipstaff.ShowCase.ViewModel
{
    public interface IEmployeeViewModel
    {
        string Surname { get; set; }

        string Forename { get; set; }

        int InternalTelephoneNumber { get; set; }

        System.Net.Mail.MailAddress EmailAddress { get; set; }

        string Image { get; set; }
    }
}
