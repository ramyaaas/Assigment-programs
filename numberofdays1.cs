using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace numberofdays
{
    class numberofdays1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the year");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the month in string");
            string mon = Console.ReadLine();
            int m = DateTime.ParseExact(mon, "MMMM", CultureInfo.CurrentCulture).Month;


            //int m = DateTime.Parse("1." + mon + "year").Month;
            int days = DateTime.DaysInMonth(year, m);
            Console.WriteLine("the number of days in the month " + mon + " during the year " + year + "  is " + days);
            Console.ReadKey();
        }
    }
}
