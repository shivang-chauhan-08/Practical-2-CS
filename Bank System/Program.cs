using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    public class InvalidInput : Exception
    {
        public InvalidInput(string msg) : base(msg) { }
    }

    public class Customer_Account
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
            try
            {
                Console.Write("Enter User Name : ");
                string name = Console.ReadLine();

                if(name == "")
                {
                    throw new InvalidInput("name cannot be null or empty");
                }

                Console.Write("Enter Account No. : ");
                long acc_no = Convert.ToInt64(Console.ReadLine());

                if (acc_no <= 0)
                {
                    throw new InvalidInput("Account Number should be greater than 0");
                }
                Console.WriteLine();

                Customer_Account acc = new Customer_Account(acc_no, name) { bank_name = "ICICI Bank" };

                // Display Info.
                acc.PrintInfo();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }             
        }
    }
}
