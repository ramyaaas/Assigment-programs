using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _27_oct_2020
{
    public partial class httpcookieassignment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button1_Click(object sender, EventArgs e)
        {
            HttpCookie id = new HttpCookie("EmployId");
            HttpCookie name = new HttpCookie("EmployName");
            HttpCookie salary = new HttpCookie("EmploySalary");
            HttpCookie desig = new HttpCookie("EmployDdesign");

            id.Value = "101";
            name.Value = "ramya";
            salary.Value = "34000";
            desig.Value = "HR";

            Response.Cookies.Add(id);
            Response.Cookies.Add(name);
            Response.Cookies.Add(salary);
            Response.Cookies.Add(desig);

            empid.Text = id.Name + ":" + id.Value;
            empname.Text = name.Name + ":" + name.Value;
            empsalary.Text = salary.Name + ":" + salary.Value;
            empdesignation.Text = desig.Name + ":" + desig.Value;

        }
    }
}