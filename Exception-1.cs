using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excpetion_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int res = a / b;
                Console.WriteLine("result is {0}", res);
                Console.ReadKey();

            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("input is invalid only integers are allowed", ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("no input received", e.Message);
            }
            Console.ReadKey();
        }
    }
}
