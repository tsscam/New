using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Empl1 = new Employee();
            Empl1.SetFirstName("Steve");
            Empl1.SetLastName("Dobbs");
            Empl1.SetStartDate(DateTime.Parse("4/1/1976"));
            Empl1.SetTitle("Programmer");
            Empl1.SetSalary(500000.0);

            Console.WriteLine(Empl1.GetFullName());

            Console.WriteLine(Empl1.GetSalary());

            Empl1.EmployeeTitle = "Manager"; // uses SET
            
            Console.WriteLine(Empl1.EmployeeTitle); //GETS the SETTED INFO



            

        }
    }
}
