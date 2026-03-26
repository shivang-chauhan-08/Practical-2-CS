using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_System
{
    internal class Customer_Account
    {
        private string Bank_Name;
        public string bank_name
        {
            get { return Bank_Name; }
            set { Bank_Name = value; }
        }
        private long Customer_AccountNo;
        public long customer_accountNo
        {
            get { return Customer_AccountNo; }
            set { Customer_AccountNo = value; }
        }
        private string Customer_Name;
        public string customer_name
        {
            get { return Customer_Name; }
            set { Customer_Name = value; }
        }

        // Parameterized Constructor
        public Customer_Account(long accountNo, string customerName)
        {
            customer_accountNo = accountNo;
            customer_name = customerName;
        }


        /// <summary>
        // This Method Prints Bank Account Information which
        // includes Bank name, Account No. & Customer Name.
        // Return Type : void
        /// </summary>
        public void PrintInfo()
        {
            Console.WriteLine("====== Bank Account Info. : ======");
            Console.WriteLine();
            Console.WriteLine($"Bank Name       : {bank_name}");
            Console.WriteLine($"Account No.     : {customer_accountNo}");
            Console.WriteLine($"Customer Name   : {customer_name}");
        }
    }
}
