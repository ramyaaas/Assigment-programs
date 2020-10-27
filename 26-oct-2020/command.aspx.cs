using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace oct_26_2020
{
    public partial class command : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void link1_Command(object sender,CommandEventArgs e)
        {
            label1.Text = "you chose" + e.CommandName + "item" + e.CommandArgument;
        }
        protected void link2_Command(object sender, CommandEventArgs e)
        {
            label1.Text = "you chose" + e.CommandName + "item" + e.CommandArgument;
        }


    }
}