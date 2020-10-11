using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queueexample
{
    class queue
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            q.Enqueue(40);
            q.Enqueue(50);
            q.Enqueue(60);
            Console.WriteLine("the number of elements in the queue is {0}", q.Count());
            foreach(int i in q)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine(q.Contains(20));
            Console.WriteLine(q.Contains(70));
            q.Dequeue();
            q.Dequeue();
            q.Dequeue();
            Console.WriteLine("the number of elements in the queue is {0}", q.Count());
            foreach (int i in q)
            {
                Console.Write(i + ",");
            }
            Console.ReadKey();



        }
    }
}
