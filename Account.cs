using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CerotidBank
{
    public class Account
    {
        public string AccountType { get; set; }

        public string AccountNumber { get; set; }

        public void PrintAccountInfo()
        {
            Console.WriteLine("Start PrintAccountInfo");
            Console.WriteLine("Account Type: {0}, Account Number {1}", AccountType, AccountNumber);
            Console.WriteLine("End PrintAccountInfo");
        }
    }
}
