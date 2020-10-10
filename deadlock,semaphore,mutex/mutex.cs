using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace mutex
{
    class Program
    {
        static void Main(string[] args)
        {
            Mutex mt = new Mutex(false, "NewMutex");
            Console.WriteLine("Waiting for the Mutex.");
            mt.WaitOne();
            Console.WriteLine("Owner of the mutex. " + "ENTER is to be pressed to release the mutexand          exit.");
            Console.ReadLine();
            mt.ReleaseMutex();
            string mutexName = "ramya";
            Mutex m = new Mutex(false, mutexName);
            for (int i=1;i<10;i++)
            {
                m.WaitOne();
                Console.WriteLine("Have Mutex");
                Console.WriteLine("Releasing");
                m.ReleaseMutex();
            }
            Console.ReadKey();
        }
    }
}
