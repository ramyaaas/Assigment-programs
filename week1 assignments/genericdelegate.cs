using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericdelegate
{
    public delegate void sample<T>(T param);
    class Program
    {
        public static void mytestmethod(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("the given number {0} is even", number);
            }
            else
            {
                Console.WriteLine("the given number {0} is odd", number);
            }
        }

        public static void mytestmethod2(string  s)
        {
            Console.WriteLine("the string length is", s.Length);
        }
        static void Main(string[] args)
        {
            sample<int> s = new sample<int>(mytestmethod);
            s(4567);
            sample<string> st = new sample<string>(mytestmethod2);
            st("dsdasdhasdggdagd");
            Console.ReadKey();
        }
    }
}
