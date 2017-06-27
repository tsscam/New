using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSetGet
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = new string('*', 20);
            Bank Bank1 = new Bank();
            Bank1.AccountCustomerName1= "John";
            Bank1.CreationDate=(DateTime.Parse("2/1/16"));
            Bank1.AccountType1=("checking");
            Bank1.Balance1 = 100;

            Bank BA1 = new Bank();
            Bank BA2 = new Bank(100001,"Steve Woz", "Checking",DateTime.Now);

            
        }
    }
}
