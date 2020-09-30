using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace largestelement
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("enter the number of elements in the array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("enter the array elements");
            for (int i = 0; i < n; i++)
            {
                Console.Write("element {0}:", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = arr[0];
            foreach(var i in arr)
            {
                if(i>=max)
                {
                    max = i;
                }
            }
            Console.WriteLine("the largest element of the array is {0}", max);
            Console.ReadKey();
        }
    }
}
