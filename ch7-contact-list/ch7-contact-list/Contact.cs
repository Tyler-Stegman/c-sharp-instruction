using System;
using System.Collections.Generic;
using System.Text;

namespace ch7_contact_list {
    class Contact {
        public string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        string Phone { get; set; }

        public Contact() {

        }

        public Contact(string firstname, string lastname, string email, string phone) {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Email = email;
            this.Phone = phone;
        }

        public override string ToString() {
            return "Contact: firstname=" + FirstName + ", lastname=" + LastName + ", email=" + Email + ", phone=" + Phone;
        }

        public string Display() {
            string ContactStr = "---------------------------------------------\n" +
                                "---- Current Contact ------------------------\n" +
                                "---------------------------------------------\n" +
                                "Name: " + FirstName + " " + LastName + "\n" +
                                "Email Address: " + Email + "\n" +
                                "Phone Number: " + Phone + "\n" +
                                "---------------------------------------------\n";
            return ContactStr;
        }
    }
}
