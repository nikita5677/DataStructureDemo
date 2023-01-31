using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueUsingLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello LinkedListQueue!");
            LinkedListQueue linkedListQueue = new LinkedListQueue();
            linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(70);
            linkedListQueue.Display();// this.top=this.top.next
            Console.ReadKey();
        }
    }
}