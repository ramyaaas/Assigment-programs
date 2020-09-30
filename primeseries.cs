using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nprimenumberseries
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            int n;
            Console.WriteLine("enter the last number");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                for (int j = 2; j < i / 2; j++)
                {
                    if (i % j == 0 && i != j)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    Console.Write("{0},",i);
                }
                flag = true;
            }

        
        Console.ReadKey();
                    
        }
    }
}
