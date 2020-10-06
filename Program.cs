using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace regex
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "xxyy";
            //match the start of a string
            if (Regex.IsMatch(test, "^xx"))
            {
                Console.WriteLine("pattern matched at the start");
            }
            //// Match the end of string 
            if (Regex.IsMatch(test, "yy$"))
            {
                Console.WriteLine("pattern matched at the end");
            }
            Console.WriteLine();
            Console.WriteLine("example2");
            string num = "2800443553";

            //match the start of a int
            if (Regex.IsMatch(num, "^28"))
            {
                Console.WriteLine("pattern matched at the start");
            }
            //// Match the end of string 
            if (Regex.IsMatch(num, "53$"))
            {
                Console.WriteLine("pattern matched at the end");
            }
            Console.ReadLine();
        }
    }
}
