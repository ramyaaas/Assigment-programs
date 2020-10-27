using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace oct_26_2020
{
    public partial class dispose : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void link1_disposed(object sender,EventArgs e)
        {
            label1.Text = "programming is fun";
        }
    }
}