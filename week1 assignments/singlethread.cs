using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singlethread
{
    class Program
    {
        public static void thread1(string s1)
        {
            int i = 0;
            while(i<10)
            {
                Console.WriteLine("the parameter that is passed to the thread is {0}", s1);
                i++;
            }
            
        }
        public static void thread2(int s)
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("the parameter that is passed to the thread is {0}", s);
                i++;
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("my main thread started");
            thread1("ramya");
            thread2(45);
            Console.WriteLine("main thread exited");
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
