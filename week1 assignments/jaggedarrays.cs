using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jaggedarrays
{
    class jaggedarrays
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[4][];
            arr[0] = new int[] { 1, 2, 3, 4 };
            arr[1] = new int[] { 4, 5, 7, 8 ,6};
            arr[2] = new int[] { 12, 56, 74, 34, 12, 334, 55 };
            arr[3] = new int[] { 456, 765 };
            for(int i=0;i<arr.Length;i++)
            {
                for(int j=0;j<arr[i].Length;j++)
                {
                    Console.Write(arr[i][j] + ",");
                }
                Console.WriteLine();
            }
            Console.ReadKey();


            
        }
    }
}
