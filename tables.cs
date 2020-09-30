using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tables
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter the table to be printed");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=10;i++)
            {
                int x = n * i;
                Console.WriteLine(""+n+"*"+i+"="+x+"");
            }
            Console.ReadKey();
        }
    }
}
