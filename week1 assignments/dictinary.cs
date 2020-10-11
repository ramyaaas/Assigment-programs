using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "ramya");
            dict[2] = "kavya";
            dict[3] = "ram";
            dict.Add(4, "sham");
            dict[5] = "kiran";
            Console.WriteLine("id   name");
            foreach (KeyValuePair<int,string> item in dict)
            {
                
                Console.WriteLine(item.Key + "   " + item.Value);
            }
            Console.WriteLine("the dictionary contains the key=={0}", dict.ContainsKey(3));
            Console.WriteLine("the dictionary contains the key=={0}", dict.ContainsKey(6));
            Console.WriteLine("the number of elements in the dictionary is {0}", dict.Count);
            dict[6] = "lakshmi";
            dict[7] = "virat";
            Console.WriteLine("id   name");
            foreach (KeyValuePair<int, string> item in dict)
            {

                Console.WriteLine(item.Key + "   " + item.Value);
            }
            dict.Remove(6);
            Console.WriteLine("id   name");
            foreach (KeyValuePair<int, string> item in dict)
            {

                Console.WriteLine(item.Key + "   " + item.Value);
            }
            Console.WriteLine("the number of elements in the dictionary is {0}", dict.Count);


            Console.ReadKey();

        }
    }
}
