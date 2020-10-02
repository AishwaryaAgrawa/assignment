using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Exception
{
    class Program
    {
        public class InvalidNumberException : Exception
        {
            public InvalidNumberException(string message) : base(message)
            {

            }
        }

        public class InvalidNameException : Exception
        {
            public InvalidNameException(string message) : base(message)
            {

            }
        }
        public class InvalidCategoryException : Exception
        {
            public InvalidCategoryException(string message) : base(message)
            {

            }
        }
            static void Main(string[] args)
        {
            Console.WriteLine("Enter the Customer Name");
            string custNo = Console.ReadLine();
            Console.WriteLine("Enter the customer name");
            string custName = Console.ReadLine();
            Console.WriteLine("Enter the category");
            string category = Console.ReadLine();
            customer cust = new customer(custNo,custName,category);

            try
            {
                cust.INExcep(custNo, custName, category);
            }

            catch (InvalidCategoryException ex)
            {
                Console.WriteLine(ex.Message);

            }
            catch (InvalidNameException ex)
            {
                Console.WriteLine(ex);

            }
            catch (InvalidNumberException exp)
            {
                Console.WriteLine(exp);
            }
          
            Console.ReadKey();
        }
        
                   
               
            
            public class InvalidException : Exception
        {
            public InvalidException(string mesasage) : base(message)
            {

            }
        } 
        }
        public class customer
        {
            private String custNo;
            private String custName;
            private String category;

            public string CustNo
            {
                get { return custNo; }
                set { custNo = value; }
            }

            public string CustName
            {
                get { return custName; }
                set { custName = value; }
                
            }

            public string Category
            {
                get { return category; }
                set { category = value; }
            }
            public void customer(string custNo,string custName,string category)
            {
                this.custNo = custNo;
                this.CustName = custName;
                this.category = category;
            }
            public void INExcep(string custNo,string custName,string category)
            {
                if (!(custNo.StartsWith("c") || custNo.StartsWith("C")))
                    throw new InvalidNumberException("number must begin with either c or C"));

                else
                    Console.WriteLine("customer Name ={0}", custNo);
                if (custName.Length < 4)
                    throw new InvalidNameException("name sholud be atleast 4 charaters");

                else
                    Console.WriteLine("customer Nmae={0}", custName);

                if (!(category == "Platinum" || category == "gold" || category == "silver"))
                    Console.WriteLine("category={0}", category);
                else
                    throw new InvalidCategoryException("category should be gold or platinum or silver");
            }

        }
    }
}
