using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _27_oct_2020
{
    public partial class datalist1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("fname");
            table.Columns.Add("lname");
            table.Columns.Add("id");
            table.Columns.Add("disignation");
            table.Columns.Add("salary");

            table.Rows.Add("ram", "kumar", "101", "hr", "45678");
            table.Rows.Add("shamam", "kumar", "102", "technician", "45678");
            table.Rows.Add("ramya", "kumari", "103", "hr", "45678");
            table.Rows.Add("laksh", "reddy", "104", "developer", "45678");
            table.Rows.Add("latha", "reddy", "105", "testing", "45678");
            table.Rows.Add("gnana", "pm", "106", "hr", "45678");

            data1.DataSource = table;
            data1.DataBind();
        }
    }
}