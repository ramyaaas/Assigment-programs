﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Codebehind : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Write("Buton clicked");
    }

    protected void TexBox1_TextChanged(object sender, EventArgs e)
    {
        string x = "Hello" + TexBox1.Text;
        Response.Write(x);

    }
}