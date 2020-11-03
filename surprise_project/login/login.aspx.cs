using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FlightTicketBookinProject
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserRegistration.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationTable"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT  * from RegistrationTable WHERE Username=@username AND Password=@password",con);
            cmd.Parameters.AddWithValue("@username", textbox1.Text);
            cmd.Parameters.AddWithValue("@password", textbox2.Text);

            int RecordCount = Convert.ToInt32(cmd.ExecuteScalar());
            
            if(RecordCount>0)
            {
                Label2.Text = "Login Successfull";
                Response.Redirect("flightbooking.aspx");

            }
            else
            {
                Label2.Text = "Invalid Username or password";
            }
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Homepage.aspx");
        }
    }
}