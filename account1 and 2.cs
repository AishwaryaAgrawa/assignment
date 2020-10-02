using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Program
{
    class Account_test
    {
        static void Main(string[] args)
        {
            string account_status = "Active";
            Account.Deposite(account_status);
            Account.Deposite("NonActive");

            Account_Dep_withdraw acc = new Account_Dep_withdraw("Active");
            acc.Deposite();
            acc.Withdraw();
            acc.Account_Details();
            Console.ReadKey();

        }
    }

    public class Account
    {
        static int balance = 0;
        public static void Deposite(string account_Status)
        {
            if (account_Status == "Active")
            {
                Console.WriteLine("Deposite Successful");
                balance++;
            }
            else
            {
                Console.WriteLine("Deposite unsuccessful Bcz Account is not active");
            }
        }
    }

    public class Account_Dep_withdraw
    {
        static int balance = 0;
        string account_status;
        public Account_Dep_withdraw(string acount_st)
        {
            account_status = acount_st;
        }

        public void Deposite()
        {
            Console.Write("Enter Ammount for Deposite : ");
            int deposite = Convert.ToInt32(Console.ReadLine());
            if (account_status == "Active")
            {
                balance = balance + deposite;
                Console.WriteLine("Deposite Successful");
            }
            else
            {
                Console.WriteLine("Deposite Unsuccessful");
            }
        }
        public void Withdraw()
        {
            Console.Write("Enter Ammount for Withdraw : ");
            int with_ammount = Convert.ToInt32(Console.ReadLine());
            if (account_status == "Active")
            {
                balance = balance - with_ammount;
                Console.WriteLine("Withdrwal successful");
            }
            else
            {
                Console.WriteLine("Withdrwal unsuccessful");
            }
        }
        public void Account_Details()
        {
            Console.WriteLine("Your Account is {0}", account_status);
            Console.WriteLine("Total Balance is {0}", balance);
        }
    }

}

