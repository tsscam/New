using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    class Employee
    {
        private double Salary;
        private string LastName;
        private string FirstName;
        private DateTime StartDate;
        private DateTime DateOfBirth;
        private string Title;

        public string EmployeeTitle
        {

            set
            {
                Title = value;
            }

            get
            {
                return Title;
            }
        }

        public string GetFullName()
        {
            return LastName + "," + FirstName;
        }
        public void SetFirstName(string input)
        {
            FirstName = input;

        }
        public void SetLastName(string input)
        {
            LastName = input;
        }
        public void SetStartDate(DateTime input)
        {
            StartDate = input;
        }
            public void SetTitle(string input)
        {
           Title = input;
        }
        public void SetSalary(double input)
        {
            Salary = input;
        }
        public double GetSalary()
        {
            return Salary;
        }
}
 

