
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberpalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, rem, reverse = 0;
            Console.WriteLine("enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            int temp = n;
            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n = n / 10;
            }
            if(temp!=reverse)
            {
                Console.WriteLine("The given number is not palindrome");
            }
            else
            {
                Console.WriteLine("The given number is  palindrome");
            }
            Console.ReadKey();
        }
    }
}
