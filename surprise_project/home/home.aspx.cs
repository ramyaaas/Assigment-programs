using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FlightTicketBookinProject
{
    public partial class Homepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserRegistration.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("mainadmin.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Contactus.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void Reservation_Click(object sender, EventArgs e)
        {
            Response.Redirect("contactus.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserRegistration.aspx");
        }
    }
}