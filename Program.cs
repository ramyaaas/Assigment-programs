using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2to100prime
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            Console.WriteLine("Prime Numbers");
            for(int i=2;i<=100;i++)
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
                    Console.WriteLine(i);
                }
                flag = true;

            }
            Console.ReadKey();




        }
            
    }    
}
