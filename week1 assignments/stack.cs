using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackexample
{
    class stack
    {
        static void Main(string[] args)
        {
            Stack<int> s = new Stack<int>();
            s.Push(10);
            s.Push(20);
            s.Push(30);
            s.Push(40);
            s.Push(50);
            Console.WriteLine("the topmost element is {0}", s.Peek());
            foreach(int x in s)
            {
                Console.WriteLine(x);

            }


            s.Pop();
            s.Pop();
            Console.WriteLine("the topmost element after popping twice is {0}", s.Peek());
            foreach (int x in s)
            {
                Console.WriteLine(x);

            }
            s.Push(40);
            s.Push(50);
            foreach (int x in s)
            {
                Console.WriteLine(x);

            }
            Console.ReadKey();



        }
    }
}
