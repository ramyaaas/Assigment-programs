using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _27_oct_2020
{
    public partial class cookiecollection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cookies["Fruits"].Expires = DateTime.Now.AddDays(-1);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label2.Text = " ";
            if (apple.Checked)
                Response.Cookies["Fruits"]["apple"] = "apple";
            if (mango.Checked)
                Response.Cookies["Fruits"]["mango"] = "mango";
            if (orange.Checked)
                Response.Cookies["Fruits"]["orange"] = "orange";
            if (banana.Checked)
                Response.Cookies["Fruits"]["banana"] = "banana";
            if (strawberry.Checked)
                Response.Cookies["Fruits"]["strawberry"] = "strawberry";
            if (Pineapple.Checked)
                Response.Cookies["Fruits"]["Pineapple"] = "Pineapple";

            if(Request.Cookies["Fruits"].Values.ToString()!=null)
            {
                if (Request.Cookies["Fruits"]["apple"] != null)
                    Label2.Text += Request.Cookies["Fruits"]["apple"] + " ";
                if (Request.Cookies["Fruits"]["mango"] != null)
                    Label2.Text += Request.Cookies["Fruits"]["mango"] + " ";
                if (Request.Cookies["Fruits"]["orange"] != null)
                    Label2.Text += Request.Cookies["Fruits"]["orange"] + " ";
                if (Request.Cookies["Fruits"]["banana"] != null)
                    Label2.Text += Request.Cookies["Fruits"]["banana"] + " ";
                if (Request.Cookies["Fruits"]["strawberry"] != null)
                    Label2.Text += Request.Cookies["Fruits"]["strawberry"] + " ";
                if (Request.Cookies["Fruits"]["Pineapple"] != null)
                    Label2.Text += Request.Cookies["Fruits"]["Pineapple"] + " ";


            }
        }
    }
}