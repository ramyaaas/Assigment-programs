using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anonymous1
{
    public delegate string Mydelegate1(string str, string str1);
    class Program
    {
        static void Main(string[] args)
        {
            Mydelegate1 obj1 = (str, str1) =>
            {
                return str + str1;
            };
            string result = obj1("virat", "kohli");
            Console.WriteLine(result);
 List<int> mylist = new List<int>()
            {
                 12,24,36,48,60,72,84,108,120
            };
            Console.WriteLine("elements of mylist are");
            foreach (var x in mylist)
            {
                Console.WriteLine("{0}", x);
            }
            Console.WriteLine();
            var cube = mylist.Select(x => x * x*x);
            foreach (var s in cube)
            {
                Console.WriteLine("{0}", s);
            }
            Console.ReadKey();

        }
    }
}
