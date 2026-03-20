using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    public class Customer_Account
    {
        public string bank_name;
        public long customer_accountNo;
        public string customer_name;

        // Parameterized Constructor
        public Customer_Account(long accountNo, string customerName)
        {
            customer_accountNo = accountNo;
            customer_name = customerName;
        }

        // This Method Prints Bank Account Information which
        // includes Bank name, Account No. & Customer Name.
        // Return Type : void
        public void PrintInfo()
        {
            Console.WriteLine("====== Bank Account Info. : ======");
            Console.WriteLine();
            Console.WriteLine($"Bank Name       : {bank_name}");
            Console.WriteLine($"Account No.     : {customer_accountNo}");
            Console.WriteLine($"Customer Name   : {customer_name}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Customer_Account acc = new Customer_Account(1234, "Shivang Chauhan") { bank_name = "ICICI Bank"};

            // Display Info.
            acc.PrintInfo();
        }
    }
}
