using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    class AdapterDP
    {
        class MainApp
        {
            static void Main(string[] args)
            {
                // Create adapter and place a request
                Target target = new Adapter();
                target.Request();
                Console.ReadKey();
            }
        }
        class Target// The 'Target' class
        {
            public virtual void Request()
            {
                Console.WriteLine("Called Target Request()");
            }
        }
        class Adapter : Target// The 'Adapter' class
        {
            private Adaptee adaptee = new Adaptee();
            public override void Request()
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
