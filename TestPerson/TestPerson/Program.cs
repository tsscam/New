using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeCls emp1 = new EmployeeCls();
            emp1.FirstName1 = "Steve";
            emp1.LastName1 = "Whiz";
            emp1.Title1 = "Engineer";
            emp1.SSN1 = "999-9999";
            emp1.Salary1 = 40000;

            ClassPerson p = new ClassPerson();
            p.FirstName1 = "Steve";
            p.LastName1 = "Jobs";
            p.SSN1 = "He is dead and doesn't have one";

            p.PrintFullName();
            p.PrintFullName();

            Manager m = new Manager();
            m.FirstName1 = "Tim";
            m.LastName1 = "Cook";
            m.Title1 = "Engineer";


            ClassPerson p1 = new ClassPerson();
            ClassPerson p2 = new Manager();

            EmployeeCls empl2 = new Manager();

            object ol = new Manager();

            ClassPerson[] PeopleList = new ClassPerson [2];
            PeopleList [0] = p;
            PeopleList[1] = emp1;
            PeopleList[2] = m;

            for (int i = 0; i < PeopleList.Length; i++)
            {
                PeopleList[i].PrintFullName();
            }
            {

            }



        }
    }
}
