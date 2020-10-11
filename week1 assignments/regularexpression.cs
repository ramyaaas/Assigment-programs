using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace regularexpression
{
    class regular
    {
        static void Main(string[] args)
        {
            string input = "/mydocuments/dotnettraining.class";

            Match match = Regex.Match(input, @"mydocuments/([A-Za-z0-9\-]+)\.class$", RegexOptions.IgnoreCase);

            if (match.Success)
            {
                string key = match.Groups[1].Value;
                Console.WriteLine(key);
            }
            Console.WriteLine();
            string test = "aaavvxxdxxllll";
            if (Regex.IsMatch(test, "^aa"))
            {
                Console.WriteLine("START MATCHES");
            }

            if (Regex.IsMatch(test, "ll$"))
            {
                Console.WriteLine("END MATCHES");
            }
            Console.WriteLine();
            Regex regex = new Regex(@"\d+");
            string result = regex.Replace("virat 5675  virat 4563", "kohli");
            Console.WriteLine("RESULT: {0}", result);

            Console.WriteLine();
            Match m = Regex.Match("12345 Xffffffffffffffy", @"X.*y");
            if (m.Success)
            {
                Console.WriteLine("Value  = " + m.Value);
                Console.WriteLine("Length = " + m.Length);
                Console.WriteLine("Index  = " + m.Index);
            }

            Console.WriteLine();

            Console.ReadKey();


        }
    }
}
