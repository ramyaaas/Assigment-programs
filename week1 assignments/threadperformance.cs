using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace singlethread
{
    class Program
    {
        public static void thread1(object s1)
        {
               string str = s1.ToString();
                int i = 0, countl = 0; 
                while (i<100)
                {
                    Console.WriteLine("the parameter that is passed to the thread is {0}", str);
                    i++;
                    countl += 1;
                }

            Console.WriteLine(countl);
            
            
        }
        public static void thread2(object s)
        {
            int x = Convert.ToInt32(s);
            int i = 0, count2 = 0;
            while (i<100)
            {
                Console.WriteLine("the parameter that is passed to the thread is {0}", x);
                i++;
                count2 += 1;
            }
            Console.WriteLine(count2);

        }

        static void Main(string[] args)
        {
            Console.WriteLine("my main thread started");
            Stopwatch s1 = new Stopwatch();
            s1.Start();
            Console.WriteLine("stopwatch is started");
            ParameterizedThreadStart p = new ParameterizedThreadStart(thread1);
            Thread T = new Thread(p);
            T.Start("ramya");
            ParameterizedThreadStart pi = new ParameterizedThreadStart(thread2);
            Thread T1 = new Thread(pi);
            
            T1.Start(456);
            
            T.Join();
            T1.Join();
            s1.Stop();
            Console.WriteLine("the ellapsed milli seconds are {0}", s1.ElapsedMilliseconds);
            Stopwatch s2= new Stopwatch();
            s2.Start();
            Console.WriteLine("stopwatch is started");
            thread1("ramya");
            thread2(4758);
            s2.Stop();
            Console.WriteLine("the ellapsed milli seconds are {0}", s2.ElapsedMilliseconds);

            Console.WriteLine("main thread exited");
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
