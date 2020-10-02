using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Product prod = new Product("Mobile", 30000, 'T');
            prod.Display_ProductDetails();
            Product prod1 = new Product("TV", 4000);
            prod1.Display_ProductDetails();
            Console.ReadKey();
        }
    }

    class Product
    {
        string pname;
        string pcode;
        double pprice;
        char catcode;

        public string Pname { get => pname; set => pname = value; }
        public string Pcode { get => pcode; set => pcode = value; }
        public double Pprice { get => pprice; set => pprice = value; }
        public char Catcode { get => catcode; set => catcode = value; }

        static int ProductCounter = 100;
        public  Product (string pn,double price, char catc)
        {
            Pname = pn;
            Pprice= price;
            Catcode = catc;
            pcode = generateProductCode();
        }

        public Product(string pn, double price)
        {
            Pname = pn;
            Pprice = price;
            Catcode = 'E';
            pcode = generateProductCode();
        }


        private string generateProductCode()
        {
            ProductCounter++;
            pcode = catcode + ProductCounter.ToString();
            return pcode;
        }

        public void Display_ProductDetails()
        {
            Console.WriteLine("\nProduct Code : {0}", Pcode);
            Console.WriteLine("Name : {0}", Pname);
            Console.WriteLine("Price : {0}", Pprice);
            Console.WriteLine("Code : {0}", Catcode);

        }

        



    }
}
