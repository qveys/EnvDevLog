using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class PrivateContact : Person
    {
        private String phoneNumber;
        private String mailAddress;
        private DateTime birthdayDate;

        public int PhoneNumber { get; set; }
        public String MailAddress { get; set; }
        public DateTime BirthdayDate { get; set; }

        public PrivateContact(String name, String lastname, String phoneNumber, String mailAddress) : base(name, lastname)
        {
            this.phoneNumber = phoneNumber;
            this.mailAddress = mailAddress;
        }

        public PrivateContact(String name, String lastname, String phoneNumber, String mailAddress, DateTime birthdayDate) : base(name, lastname)
        {
            this.phoneNumber = phoneNumber;
            this.mailAddress = mailAddress;
            this.birthdayDate = birthdayDate;
        }

        public override bool BirthdayWish()
        {
            return (DateTime.Today.Month == birthdayDate.Month && DateTime.Today.Day == birthdayDate.Day);
        }

        public override string ToString()
        {
            return base.ToString() + " (" + phoneNumber + ") \n" + mailAddress;
        }
    }
}
