using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CerotidBank
{
    public class Bank
    {
        public string BankName { get; set; }

        public List<Customer> Customers { get; set; }

        public Bank()
        {
            Customers = new List<Customer>();

        }

        public void PrintBankName()
        {
            Console.WriteLine("Start PrintBankName");
            Console.WriteLine("BankName:{0}", BankName);
            Console.WriteLine("Finish PrintBankName");
        }
        public void PrintBankDetails()
        {
            Console.WriteLine("Start PrintBankDetails");
            Console.WriteLine("BankName:{0}", BankName);
            foreach (Customer cust in Customers)
            {
                //do this 
                Console.WriteLine("Customer Name: {0}, Address{1}", cust.CustomerName, cust.Address);
            }
            Console.WriteLine("Finsihed PrintBankDetails");
        }
    }
}
