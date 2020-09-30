using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace armstrong
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, arm=0, rem;
            Console.WriteLine("enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            int temp = n;
            while(n!=0)
            {
                rem = n % 10;
                arm=arm+rem * rem * rem;
                n = n / 10;
            }

            if(temp==arm)
            {
                Console.WriteLine("{0}={1}", temp, arm);
                Console.WriteLine("the given number is armstron number");
            }
            else
            {
                Console.WriteLine("the given is not armstrong");
            }
            Console.ReadKey();

        }
    }
}
