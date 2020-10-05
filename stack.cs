using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackassigment
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> x = new Stack<int>();
            x.Push(2);
            x.Push(4);
            x.Push(6);
            x.Push(8);
            x.Push(10);
            x.Push(12);
            x.Push(14);
            x.Push(16);
            x.Push(18);
            x.Push(20);
            Console.WriteLine("the topmost element of the stack is {0} ", x.Peek());
            foreach ( var i in x)
            {
                Console.WriteLine("the elemnets of the stack are {0}", i);
            }

            x.Pop();
            x.Pop();
            x.Pop();
            x.Pop();
            x.Pop();
            x.Pop();
            Console.WriteLine("after 6 pop operations");
            Console.WriteLine("the topmost element of the stack is {0} ", x.Peek());

            foreach(int z in x)
            {
                Console.WriteLine("the elemnets of the stack are {0}", z);
            }

            x.Pop();
            x.Pop();
            x.Pop();
            Console.WriteLine("the topmost element of the stack is {0} ", x.Peek());
            x.Pop();
            x.Pop();
            foreach (int z in x)
            {
                Console.WriteLine("the elemnets of the stack are {0}", z);
            }
            Console.ReadKey();

        }
    }
}
