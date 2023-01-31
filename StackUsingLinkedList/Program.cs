using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUsingLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello LinkedList Stack!");
            LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.Push(70);
            linkedListStack.Push(30);
            linkedListStack.Push(56);
            linkedListStack.Display();
            //linkedListStack.Peek(); top.data
            //linkedListStack.Pop();
            //linkedListStack.IsEmpty();
            //linkedListStack.Display();
            Console.ReadKey();
        }
    }
}
