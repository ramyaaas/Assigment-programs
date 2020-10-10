using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace deadlock
{
    public class deadlockexample
    {
        static readonly object firstLock = new object();
        static readonly object secondLock = new object();
        static void ThreadJob()
        {
            Console.WriteLine("\t\t\t\tLocking firstLock");
            lock (firstLock)
            {
                Console.WriteLine("\t\t\t\tLocked firstLock");
                
                Thread.Sleep(1000);
                Console.WriteLine("\t\t\t\tLocking secondLock");
                lock (secondLock)
                {
                    Console.WriteLine("\t\t\t\tLocked secondLock");
                }
                Console.WriteLine("\t\t\t\tReleased secondLock");
            }
            Console.WriteLine("\t\t\t\tReleased firstLock");
        }
       
    
        static void Main(string[] args)
        {
                new Thread(new ThreadStart(ThreadJob)).Start();
                
                Thread.Sleep(500);
                Console.WriteLine("Locking secondLock");
                lock (secondLock)
                {
                    Console.WriteLine("Locked secondLock");
                    Console.WriteLine("Locking firstLock");
                    lock (firstLock)
                    {
                        Console.WriteLine("Locked firstLock");
                    }
                    Console.WriteLine("Released firstLock");
                }
                Console.WriteLine("Released secondLock");
                Console.Read();
        }
    }
}
