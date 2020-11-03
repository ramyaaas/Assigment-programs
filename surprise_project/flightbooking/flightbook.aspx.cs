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
    public partial class flightbooking : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationTable"].ConnectionString);
            con.Open();
            var insertQuery = "insert into FlightBooking(Username,Age,Gender,Source,Destination,Class) values (@name,@age,@gender,@source,@destination,@class)";
            SqlCommand cmd = new SqlCommand(insertQuery, con);
            string gender = string.Empty;
            if (RadioButton1.Checked)
            {
                gender = "male";
            }
            else if (RadioButton2.Checked)
            {
                gender = "female";
            }
            cmd.Parameters.AddWithValue("@name", textbox1.Text);
            cmd.Parameters.AddWithValue("@age", textbox2.Text);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@source", DropDownList2.Text);
            cmd.Parameters.AddWithValue("@destination", DropDownList3.Text);
            cmd.Parameters.AddWithValue("@class", DropDownList1.Text);
             int affectedrows=cmd.ExecuteNonQuery();
            if(affectedrows>0)
            {
                Label2.Text = "Ticket booking is successfull!!!!!!!!!!!!!!";
            }

            else
            {
                Label2.Text = "Ticket booking falied!!!!!!!!!!!!!!!!!!!!!";
            }
            con.Close();

            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["value"] = textbox1.Text;
            Session["value1"] = textbox2.Text;
            Session["value4"] = DropDownList2.Text;
            Session["value5"] = DropDownList3.Text;
            if(RadioButton1.Checked)
            {
                Session["value3"] = RadioButton1.Text;
            }
            else
            {
                Session["value3"] = RadioButton2.Text;
            }
            Session["value6"] = DropDownList1.Text;
            Response.Redirect("ticketgeneration.aspx");
        }
    }
}