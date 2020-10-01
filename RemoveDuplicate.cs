using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicate
{
    class RemoveDuplicate
    {
       static void Main(string[] args)
        {
            int n, i, j, x;
            int[] arr = new int[15];
            Console.WriteLine("enter the size of array");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter array elements");
            for(i=0;i<n;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("the array elements after removing duplicate elements");
            for(i=0;i<n;i++)
            {
                for(j=i+1;j<n;)
                {
                    if(arr[i]==arr[j])
                    {
                        for(x=j;x<n;x++)
                        {
                            arr[x] = arr[x + 1];
                        }
                        n--;
                    }
                    else
                    {
                        j++;
                    }
                }
            }

            for(i=0;i<n;i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();

        }
    }
}
