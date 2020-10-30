using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
namespace _29_10_2020
{
    public partial class rapid_development : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationTable"].ConnectionString);
            con.Open();
            var insertQuery = "insert into RegistrationTable (Id,Name,Password,Email,Gender,City) values (@Id,@Name,@Password,@email,@Gender,@City)";
            SqlCommand cmd = new SqlCommand(insertQuery, con);
            string gender = string.Empty;
            if(RadioButton1.Checked)
            {
                gender = "male";
            }
            else if(RadioButton2.Checked)
            {
                gender = "female";
            }
            cmd.Parameters.AddWithValue("@Id", TextBox7.Text);
            cmd.Parameters.AddWithValue("@Name", TextBox5.Text);
            cmd.Parameters.AddWithValue("@Password", TextBox4.Text);
            cmd.Parameters.AddWithValue("@email", TextBox6.Text);
            cmd.Parameters.AddWithValue("@Gender",gender);
            cmd.Parameters.AddWithValue("@City",DropDownList1.Text);
            cmd.ExecuteNonQuery();

            Response.Write("Registration successfullt completed data inserted");
            con.Close();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("admin.aspx");
        }
    }
}