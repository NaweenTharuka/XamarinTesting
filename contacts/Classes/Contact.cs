using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace contacts.Classes
{
    public class Contact
    {
        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get;
            set;
        }

        public string Firstname {
            get;
            set;
        }

        public string Lastname
        {
            get;
            set;
        }

        public string Email
        {
            get;
            set;
        }

        [MaxLength(10)]
        public string PhoneNumber
        {
            get;
            set;
        }

        public string Address
        {
            get;
            set;
        }

        public Contact() { 
        }

    }
}
