using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CerotidBank
{
    public class Customer
    {
        public string CustomerName { get; set; }

        public List<Account> Accounts { get; set; }

        public string Address { get; set; }

        public void PrintCustomerAccounts()
        {
            Console.WriteLine("Start PrintCustomerAccounts");
            foreach (Account act in Accounts)
            {
                Console.WriteLine("Account Type:{0}, Account Number {1}", act.AccountType, act.AccountNumber);
            }
            Console.WriteLine("Finished PrintCustomerAccounts");
        }

        public void PrintCustomerDetails()
        {
            Console.WriteLine("Start PrintCustomerDetails");
            Console.WriteLine("Customer Name: {0},  Address:{1}", CustomerName);
            Console.WriteLine("Start PrintCustomerDetails");


        }
    }
}