using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumofdigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, remainder, sum = 0, choice=0;
            
                Console.WriteLine("enter the number");
                n = Convert.ToInt32(Console.ReadLine());
                while (n != 0)
                {
                    remainder = n % 10;
                    sum += remainder;
                    n = n / 10;
                }
            Console.WriteLine(sum);
            
            Console.ReadKey();
        }
    }
}
