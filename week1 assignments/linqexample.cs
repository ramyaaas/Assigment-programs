using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqexample
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
                new student(){id=105,name="ballarya",age=10,std=5},
            };

            var names = mylist.Where(s => s.id > 102).Select(s => s).Where(st => st.age < 10).Select(st => st.name);
            foreach(var item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*****************************************************");
            var query = mylist.Where(s => s.name.StartsWith("bal")).Select(s => s).Where(st => st.age <= 10).Select(st => st.name);
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*****************************************************");
            var query1 = from m in mylist
                         where m.id < 105
                         where m.age < 10
                         group m by m.id into ml
                         orderby ml.Key
                         select new { ml.Key, ml };
            foreach(var item in query1)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }
    }
}
