using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic
{
    class example<T>//class should contain type parameter
    {
        T data;//parameter declared
        //create a method for class example
        public example(T check)//check is assigned to type parameter

        {
            this.data = check;
        }
        public void write()
        {
            Console.WriteLine("the value passed to the initializer is:" + this.data);
        }
    }

    class generics_practice
    {
        //driver method
        static void Main(string[] args)
        {
            //use the generic type example with an integer or a string type parameter
            //instantiating the class example
            example<int> result = new example<int>(300);
            example<string> result1 = new example<string>("prathyusha");


            //invoking the method
            result.write();
            result1.write();
            Console.ReadLine();
        }
    }
}
