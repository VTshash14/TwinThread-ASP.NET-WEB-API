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
    public partial class loggedIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            //querry database to find user name
            string userName = TextBox1.Text;

            //Open sql connection
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UserConnectionString"].ConnectionString);
            conn.Open();

            //First Name
            string querry1 = "SELECT * FROM User_Table WHERE email='" + userName + "'";
            SqlCommand cmd1 = new SqlCommand(querry1, conn);
            Label5.Text = cmd1.ExecuteScalar().ToString();

            //Last Name
            string querry2 = "SELECT lastName FROM User_Table WHERE email='" + userName + "'";
            SqlCommand cmd2 = new SqlCommand(querry2, conn);
            Label6.Text = cmd2.ExecuteScalar().ToString();

            //Email
            string querry3 = "SELECT Email FROM User_Table WHERE email='" + userName + "'";
            SqlCommand cmd3 = new SqlCommand(querry3, conn);
            Label7.Text = cmd3.ExecuteScalar().ToString();

            //password
            string querry4 = "SELECT Password FROM User_Table WHERE email='" + userName + "'";
            SqlCommand cmd4 = new SqlCommand(querry4, conn);
            Label8.Text = cmd4.ExecuteScalar().ToString();

            //close
            conn.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("edit.aspx");
        }
    }
}