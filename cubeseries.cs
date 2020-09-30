using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cubeofanumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("enter the last number");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                x = i * i * i;
                Console.Write("{0},", x);

            }
            Console.ReadKey();
        }
    }
}
