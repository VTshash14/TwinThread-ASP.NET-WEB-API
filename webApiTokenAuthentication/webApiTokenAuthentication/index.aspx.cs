using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace webApiTokenAuthentication
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        //login button
        protected void Button1_Click(object sender, EventArgs e)
        {
            string userName = TextBox5.Text;
            string password = TextBox6.Text;

            //open connection to database
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UserConnectionString"].ConnectionString);
            conn.Open();
            string pass_db = "SELECT Password FROM User_Table WHERE Email='" + userName + "'";
            SqlCommand cmd = new SqlCommand(pass_db, conn);

            string checkPass = cmd.ExecuteScalar().ToString();

            //Label1.Text = "password: " + checkPass;

            conn.Close();
            if (password == checkPass)
                Response.Redirect("loggedIn.aspx");
            else
                Label1.Text = "Invalid Login";
        }

        //register button
        protected void Button2_Click1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UserConnectionString"].ConnectionString);
                conn.Open();
                string insertQuery = "insert into User_Table(firstName, lastName, Email, Password)values (@firstName, @lastName, @email, @password)";
                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@firstName", TextBox1.Text);
                cmd.Parameters.AddWithValue("@lastName", TextBox2.Text);
                cmd.Parameters.AddWithValue("@email", TextBox3.Text);
                cmd.Parameters.AddWithValue("@password", TextBox4.Text);
                cmd.ExecuteNonQuery();

                Response.Write("Student registeration Successfully!");

                conn.Close();

            }
            catch (Exception ex)
            {
                Response.Write("error" + ex.ToString());
            }
        }
    }
}