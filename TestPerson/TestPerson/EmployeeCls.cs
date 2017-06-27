using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPerson
{
    class EmployeeCls:ClassPerson
    {
        private double Salary;
        private string Title;

        public double Salary1
        {
            get
            {
                return Salary;
            }

            set
            {
                Salary = value;
            }
        }

        public string Title1
        {
            get
            {
                return Title;
            }

            set
            {
                Title = value;
            }
        }
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName1 + "," + LastName1 + "." );
        }
        }
    }

