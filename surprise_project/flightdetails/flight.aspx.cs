using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FlightTicketBookinProject
{
    public partial class flightdetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationTable"].ConnectionString);
            con.Open();
            var insertQuery = "insert into FlightDetails (Id,flightnumber,flightname,source,destination) values (@Id,@number,@name,@source,@destination)";
            SqlCommand cmd = new SqlCommand(insertQuery, con);


            cmd.Parameters.AddWithValue("@Id", texbox1.Text);
            cmd.Parameters.AddWithValue("@number", textBox2.Text);
            cmd.Parameters.AddWithValue("@name", textbox3.Text);
            cmd.Parameters.AddWithValue("@source", textBox4.Text);
            cmd.Parameters.AddWithValue("@destination", textBox5.Text);
          
            int affectedrows=cmd.ExecuteNonQuery();
            if(affectedrows>0)
            {
                Response.Write("Flight added successfully!!!!!!!!!!!");
            }
            else
            {
                Response.Write("Flight details adding failed!!!!!!!!!!!!");
            }
        }
    }
}