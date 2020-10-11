using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anonymous
{
    public delegate void Anonymous1(string str, string str1);
    class Program
    {
        public static void example1(string firstname, string lastname)
        {
            Console.WriteLine("Firstname Lastname");
            Console.WriteLine(firstname + lastname);
        }
        static void Main(string[] args)
        {

            Anonymous1 m = new Anonymous1(example1);
            m.Invoke("virat", "kohli");

            Anonymous1 m1 = delegate (string f, string l)
              {
                  Console.WriteLine("Firstname Lastname");
                  Console.WriteLine(f + l);
              };
            m1.Invoke("ramya", "pm");
            Console.ReadKey();




        }
    }
}
