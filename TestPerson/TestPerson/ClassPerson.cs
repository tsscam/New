using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPerson
{
    class ClassPerson
    {
        private string FirstName;
        private string LastName;
        private string SSN;

        public string FirstName1
        {
            get
            {
                return FirstName;
            }

            set
            {
                FirstName = value;
            }
        }

        public string LastName1
        {
            get
            {
                return LastName;
            }

            set
            {
                LastName = value;
            }
        }

        public string SSN1
        {
            get
            {
                return SSN;
            }

            set
            {
                SSN = value;
            }
        }

        public virtual void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName1);
        }
    }
}

