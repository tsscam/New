using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPerson
{
    class Manager:EmployeeCls
    {   //variable
        private int NoShares;
        //property
        public int NoShares1
        {
            get
            {
                return NoShares;
            }

            set
            {
                NoShares = value;
            }
        }
        public override void PrintFullName()
        {
            Console.WriteLine(LastName1 + "," + FirstName1 + "," + Title1 + ",");
        }
    }
}
