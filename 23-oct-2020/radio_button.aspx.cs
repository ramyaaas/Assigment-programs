using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class radio_button : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Red_CheckedChanged(object sender, EventArgs e)
    {
        Response.Write("This is Red Color");
    }

    protected void Blue_CheckedChanged(object sender, EventArgs e)
    {
        Response.Write("This is Blue color");
    }

    protected void Green_CheckedChanged(object sender, EventArgs e)
    {
        Response.Write("This is Green color");
    }

    protected void Unnamed1_TextChanged(object sender, EventArgs e)
    {
        Response.Write("This is Red color");

    }

    protected void Unnamed2_TextChanged(object sender, EventArgs e)
    {
        Response.Write("This is Blue color");
    }

    protected void Unnamed3_TextChanged(object sender, EventArgs e)
    {
        Response.Write("This is Green color");
    }

    protected void Unnamed1_Click(object sender, EventArgs e)
    {
        Response.Write("this is red clr");
    }

    protected void Unnamed2_Click(object sender, EventArgs e)
    {
        Response.Write("this is blue clr");
    }

    protected void Unnamed3_Click(object sender, EventArgs e)
    {
        Response.Write("this is green clr");
    }
}