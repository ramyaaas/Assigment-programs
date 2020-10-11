using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int, int> addel = add;
            addel(1, 2);


            Func<int, int, int> sumfunc = sum;
            int s = sumfunc(3, 4);
            Console.WriteLine(s);
            


            Predicate<int> val = chkeven;
            Console.WriteLine(val(10));
            Console.ReadKey();




        }

        public static void add(int x,int y)
        {
            Console.WriteLine($"{(x + y)}");
        }

        public static int sum(int a,int b)
        {
            return a + b;
        }

        public static bool chkeven(int a)
        {
            if (a % 2 == 0) 
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
