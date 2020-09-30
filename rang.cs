using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rangenumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int f, l;
            Console.WriteLine("enter the starting number");
            f = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the last number");
            l = Convert.ToInt32(Console.ReadLine());
            for(int i=f;i<=l;i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
