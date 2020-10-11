using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listexample
{
    class student
    {
        public int id;
        public string name;
        public int age;
        public int std;
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<student> mylist = new List<student>()
            {
                new student(){id=101,name="ramya",age=11,std=7 },
                new student(){id=102,name="gnana",age=15,std=10 },
                new student(){id=103,name="asha",age=6,std=1 },
                new student(){id=104,name="ballu",age=8,std=2 },
                new student(){id=105,name="nayana",age=10,std=5},
            };
            Console.WriteLine("id     name   age    std");
            foreach(var item in mylist)
            {
                Console.WriteLine(item.id + "  " + item.name + "  " + item.age + "  " + item.std);
            }
            List<string> mylist1 = new List<string>();
            mylist1.Add("navya");
            mylist1.Add("kavya");
            mylist1.Add("naveen");
            mylist1.Add("ghanavi");
            mylist1.Add("ram");
            Console.WriteLine("the contents of the list are");

            foreach(var i in mylist1)
            {
                Console.WriteLine(i + ",");
            }
            Console.WriteLine("the numbr of elements in the list are", mylist.Count());
            Console.WriteLine("the numbr of elements in the list are", mylist1.Count());
            Console.WriteLine(mylist1.Contains("naveen"));
            mylist1.Insert(6, "sham");
            Console.WriteLine("the contents of the list are");

            foreach (var i in mylist1)
            {
                Console.WriteLine(i + ",");
            }
            Console.WriteLine("the index of naveen is {0}", mylist1.IndexOf("naveen"));
            Console.WriteLine(mylist1.Remove("sham"));
            Console.ReadKey();
        }
    }
}
