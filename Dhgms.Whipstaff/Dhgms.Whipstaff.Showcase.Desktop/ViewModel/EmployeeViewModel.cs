using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.Whipstaff.ShowCase.ViewModel
{
    using System.Net.Mail;

    using ReactiveUI;

    public class EmployeeViewModel : ReactiveObject, IEmployeeViewModel, IRoutableViewModel
    {
        private string domainUsername;

        private string forename;

        private string surname;

        private MailAddress emailAddress;

        private int internalTelephoneNumber;

        private string image;

        public string UrlPathSegment
        {
            get
            {
                return "Employee";
            }
        }

        public IScreen HostScreen { get; protected set; }

        public string DomainUsername
        {
            get
            {
                return this.domainUsername;
            }

            set
            {
                this.RaiseAndSetIfChanged(ref this.domainUsername, value);
            }
        }

        public string Forename
        {
            get
            {
                return this.forename;
            }

            set
            {
                this.RaiseAndSetIfChanged(ref this.forename, value);
            }
        }

        public string Surname
        {
            get
            {
                return this.surname;
            }

            set
            {
                this.RaiseAndSetIfChanged(ref this.surname, value);
            }
        }

        public System.Net.Mail.MailAddress EmailAddress
        {
            get
            {
                return this.emailAddress;
            }

            set
            {
                this.RaiseAndSetIfChanged(ref this.emailAddress, value);
            }
        }

        public int InternalTelephoneNumber
        {
            get
            {
                return this.internalTelephoneNumber;
            }

            set
            {
                this.RaiseAndSetIfChanged(ref this.internalTelephoneNumber, value);
            }
        }

        public string Image
        {
            get
            {
                return this.image;
            }

            set
            {
                this.RaiseAndSetIfChanged(ref this.image, value);
            }
        }
    }
}
