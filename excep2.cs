using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exp2
{
    class Program
    {
        public class InvalidNumberException : Exception
        {
            public InvalidNumberException(string message) : base(message)
            {

            }
        }

        public class InvalidNameException : Exception
        {
            public InvalidNameException(string message) : base(message)
            {

            }
        }
        public class InvalidCategoryException : Exception
        {
            public InvalidCategoryException(string message) : base(message)
            {

            }
        }




        class customer
        {
            private string CustNo;
            private string CustName;
            private string category;


            public customer(string number, string name, string category)
            {
                this.CustNo = number;
                this.CustName = name;
                this.category = category;

                if (CustNo[0] != 'c' || CustNo[0] != 'C')
                {

                    throw new InvalidNumberException("number must begin with either c or C");

                }

                if (CustName.Length > 4)
                {
                    throw new InvalidNameException("name sholud be atleast 4 charaters");
                }

                if (category == "Platinum" || category == "Gold" || category == "Silver")
                {
                    throw new InvalidCategoryException("category should be gold or platinum or silver");
                }
            }


            static void Main(string[] args)
            {
                try
                {
                    customer c = new customer("A123", "ersd", "Gold");
                }
                catch (InvalidCategoryException e)
                {
                    Console.WriteLine(e);

                }
                catch (InvalidNameException ex)
                {
                    Console.WriteLine(ex);

                }
                catch (InvalidNumberException exp)
                {
                    Console.WriteLine(exp);
                }
                Console.ReadKey();
            }
        }
    }
}
