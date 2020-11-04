using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    class AdapterDesignPattern
    {
        class MainApp
        {
            static void Main()
            {
                // Create adapter and place a request
                Target target = new Adapter();
                Adapter obj = new Adapter();
                target.Request();
                obj.Request1();
                Console.ReadKey();
            }
        }
        class Target// The 'Target' class
        {
            public void Request()
            {
                Console.WriteLine("Called Target Request()");
            }
        }
        class Adapter : Target// The 'Adapter' class
        {
            private Adaptee adaptee = new Adaptee();
            public void Request1()
            {
                adaptee.SpecificRequest();
            }
        }
        class Adaptee// The 'Adaptee' class
        {
            public void SpecificRequest()
            {
                Console.WriteLine("Called SpecificRequest()");
            }
        }
    }
}