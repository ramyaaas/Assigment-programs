using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, string> names = new SortedList<string, string>();
            names.Add("1", "asha");
            names.Add("4", "agasthya");
            names.Add("5", "babu");
            names.Add("3", "Roshan");
            names.Add("2", "anitha");
            foreach (KeyValuePair<string, string> kv in names)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }
            Console.ReadKey();
        }
    }
}
