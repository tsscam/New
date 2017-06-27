using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceOOP
{
    class Person
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }

        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public Person()
        {
            firstName = "Not Set";
            lastName = "Not Set";

        }
        public Person (string firstName, string lastName)
        {
            firstName = FirstName;
            lastName = LastName;
        }
    }
}
