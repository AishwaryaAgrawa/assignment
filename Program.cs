using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queueusingint
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> MyQueue = new Queue<int>(); //queue object created

            MyQueue.Enqueue(2);
            MyQueue.Enqueue(4);
            MyQueue.Enqueue(6);
            MyQueue.Enqueue(8);
            MyQueue.Enqueue(10);
            MyQueue.Enqueue(12);
            MyQueue.Enqueue(14);
            MyQueue.Enqueue(16);
            MyQueue.Enqueue(18);
            MyQueue.Enqueue(20);

            foreach (int DEX in MyQueue)
            {
                Console.WriteLine("Queue elements entered are : " + DEX);

            }
            Console.WriteLine("Elements left after applying DeQueue method : " + MyQueue.Dequeue());
            Console.WriteLine("Elements left after applying DeQueue method : " + MyQueue.Dequeue());
            Console.WriteLine("Elements left after applying DeQueue method : " + MyQueue.Dequeue());
            Console.WriteLine("Elements left after applying DeQueue method : " + MyQueue.Dequeue());
            Console.WriteLine("Elements left after applying DeQueue method : " + MyQueue.Dequeue());
            Console.WriteLine("Elements left after applying DeQueue method : " + MyQueue.Dequeue());//fifo?? access the element with first present
            Console.WriteLine("peek element of the queue is : " + MyQueue.Peek());
            Console.WriteLine("the current elements prsenet in the queue : " + MyQueue.Count());

            Console.WriteLine("Elements left after applying DeQueue method : " + MyQueue.Dequeue());
            Console.WriteLine("Elements left after applying DeQueue method : " + MyQueue.Dequeue());
            Console.WriteLine("Elements left after applying DeQueue method : " + MyQueue.Dequeue());

            Console.WriteLine("peek element of the queue is : " + MyQueue.Peek());
            Console.WriteLine("the current elements prsenet in the queue : " + MyQueue.Count());

        }
    }
}
