using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("enter the string to be checked whether it is palindrome or not");
            str = Console.ReadLine();
            string str1 = str;

            if (str == str1)
            {
                Console.WriteLine("the given string  {0} is palindrom", str);
            }
            else
            {
                Console.WriteLine("the given string  {0} is not palindrome", str);
            }
            Console.ReadKey();
        }
    }
}
