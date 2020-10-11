using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateexample
{
    public delegate void MyDelegate(int msg);
    public delegate void MyDelegate1(string msg);
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate del = myclass1.mydata1;
            del.Invoke(23);

            MyDelegate1 del1 = Myclass2.mydata2;
            del1.Invoke("ramya");
        }
                

            
    }
    
    class myclass1
    {
        public static void mydata1(int a)
        {
            Console.WriteLine("Called myclass1.mydata1 with parameter: " + a);
        }
    }

    class Myclass2
    {
        public static void mydata2(string b)
        {
            Console.WriteLine("Called Myclass2.mydata2() method with parameter: " + b);
        }
    }
}
