using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threadpriorities
{
   
    class Program
    {
        static long count1, count2, count3, count4, count5;

        public long Count1 { get;  set; }
        public long Count2 { get;  set; }

        public static void IncrementCount1()
        {
            while (true)
            {
                count1 += 1;
                Console.WriteLine("thread 1 started");
            }
        }
        public static  void IncrementCount2()
        {
            while (true)
            {
                count2 += 1;
                Console.WriteLine("thread 2 started");
            }
        }
        public static void IncrementCount3()
        {
            while (true)
            {
                count3 += 1;
                Console.WriteLine("thread 3 started");
            }
        }
        public static void IncrementCount4()
        {
            while (true)
            {
                count4 += 1;
                Console.WriteLine("thread 4 started");
            }
        }
        public static void IncrementCount5()
        {
            while (true)
            {
                count5 += 1;
                Console.WriteLine("thread 5 started");
            }
        }

        static void Main(string[] args)
        {
           // threadpriority obj = new threadpriority();
            Thread T = new Thread(IncrementCount1);
            Thread T1 = new Thread(IncrementCount2);
            Thread T2 = new Thread(IncrementCount3);
            Thread T3 = new Thread(IncrementCount4);
            Thread T4 = new Thread(IncrementCount5);
            Console.WriteLine("main thread going to sleep for 5 seconds");
            Thread.Sleep(10000);
            Console.WriteLine("the main thread wake up");
            T.Priority = ThreadPriority.Normal;
            T1.Priority = ThreadPriority.Highest;
            T1.Priority = ThreadPriority.Lowest;
            T1.Priority = ThreadPriority.AboveNormal;
            T1.Priority = ThreadPriority.BelowNormal;

            T.Start();T1.Start();T2.Start();T3.Start();T4.Start();
            T.Abort(); T1.Abort();T2.Abort();T3.Abort();T4.Abort();

            T.Join();
            T1.Join();
            T2.Join();
            T3.Join();
            T4.Join();


            Console.WriteLine(count1);
            Console.WriteLine(count2);
            Console.WriteLine(count3);
            Console.WriteLine(count4);
            Console.WriteLine(count5);

            Console.ReadKey();


        }
    }
}
