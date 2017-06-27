using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSetGet
{
    class Bank
    {
        #region Variablle
        private string CustomerName;
        private double Balance;
        private string AccountType;
        private double AccountBalance;
        private string AccountCustomerName;
        DateTime AccountCreationDate;

        #endregion

        #region Properties
        public DateTime AccountCreationDate
        {
            get
            {
                return AccountCreationDate;
            }

            set
            {
                AccountCreationDate = value;
            }
        }

        public DateTime CreationDate
        {
            get
            {
                return CreationDate;
            }

            set
            {
                CreationDate = value;
            }
        }

        public string AccountCustomerName1
        {
            get
            {
                return AccountCustomerName;
            }

            set
            {
                AccountCustomerName = value;
            }
        }

        public double AccountBalance1
        {
            get
            {
                return AccountBalance;
            }

            set
            {
                AccountBalance = value;
            }
        }

        public string AccountType1
        {
            get
            {
                return AccountType;
            }

            set
            {
                AccountType = value;
            }
        }

        public double Balance1
        {
            get
            {
                return Balance;
            }

            set
            {
                Balance = value;
            }
        }

        public string CustomerName1
        {
            get
            {
                return CustomerName;
            }

            set
            {
                CustomerName = value;
            }
        }
        #endregion

        public Bank(double BalanceInput, 
            string CustomerName, 
            string AccountType1Input, DateTime CreationDateInput )
        {
            Balance = BalanceInput;
            AccountType = AccountType1Input;
           
         }
        public Bank()
        {
            Balance = 100;
            CustomerName = "----";
            AccountType1 = ("checking");
            
            
        }
    }
}
