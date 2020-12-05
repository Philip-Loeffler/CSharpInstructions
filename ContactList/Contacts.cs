using System;
namespace ContactList {
    class Contacts {

        public String firstName { get; set; }
        public String lastName { get; set; }
        public String email { get; set; }
        public int phoneNumber { get; set; }

        public Contacts() {

        }

        public Contacts(string firstName, string lastName, string email, int phoneNumber) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phoneNumber = phoneNumber;
        }

    }
}

