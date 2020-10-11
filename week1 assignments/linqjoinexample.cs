using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqjoinsortexamples
{
    class employee
    {
        public string employee_name { get; set; }
        public int employee_id { get; set; }
        public long employee_salary { get; set; }
        public string employee_designation { get; set; }
        public int department_id { get; set; }

    }
    class department
    {
        public int department_id { get; set; }
        public string depart_name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<employee> employeelist = new List<employee>()
            {
                new employee(){employee_name="ramya",employee_id=101,employee_salary=25000,employee_designation="software engineer",department_id=1},
                new employee(){employee_name="ram",employee_id=102,employee_salary=45000,employee_designation="HR",department_id=1},
                new employee(){employee_name="kavya",employee_id=103,employee_salary=30000,employee_designation="software engineer",department_id=2},
                new employee(){employee_name="rohit",employee_id=104,employee_salary=43000,employee_designation="technician",department_id=4},
                new employee(){employee_name="virat",employee_id=105,employee_salary=52000,employee_designation="manager",department_id=3},
                new employee(){employee_name="gnana",employee_id=106,employee_salary=90000,employee_designation="HR",department_id=2},

            };

            List<department> departmentlist = new List<department>()
            {
                new department(){department_id='1',depart_name="CS"},
                new department(){department_id='2',depart_name="EE"},
                new department(){department_id='3',depart_name="EC"},
                new department(){department_id='4',depart_name="CIVIL"},
                new department(){department_id='5',depart_name="MECHANICAL"},
            };

            var query1 = from ep in employeelist
                         join dp in departmentlist
                         on ep.department_id equals dp.department_id
                         select new { epname = ep.employee_name, dpname = dp.depart_name, empdesgnation = ep.employee_designation };
            foreach(var x in query1)
            {
                Console.WriteLine(x.epname + "," + x.dpname + "," + x.empdesgnation);
            }
            Console.WriteLine("=======================================================");

            var query = from e in employeelist
                        join d in departmentlist
                        on e.department_id equals d.department_id
                        select new {  employeename=e.employee_name, depatmentname=d.depart_name };
            foreach(var i in query)
            {
                Console.WriteLine(i.employeename + "," + i.depatmentname);
            }


            

            Console.ReadKey();

        }
    }
}
