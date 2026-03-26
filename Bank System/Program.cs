using Bank_System.Exceptions;

namespace Bank_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter User Name : ");
                string name = Console.ReadLine();

                if (name == "")
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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}