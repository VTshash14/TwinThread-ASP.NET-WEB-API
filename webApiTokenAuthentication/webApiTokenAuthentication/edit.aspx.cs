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
    public partial class edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //update button clicked
        protected void Button1_Click(object sender, EventArgs e)
        {
            string userName = TextBox1.Text;
            string firstName = TextBox4.Text;
            string lastName = TextBox2.Text;
            string password = TextBox3.Text;

            //Open sql connection
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UserConnectionString"].ConnectionString);
            conn.Open();

            string querry = "UPDATE User_Table SET firstName='" + firstName + "', lastName='" + lastName + "', password='" + password + "' WHERE email='" + userName + "'";
            SqlCommand cmd = new SqlCommand(querry, conn);

            cmd.ExecuteScalar();

            conn.Close();

            Response.Redirect("loggedIn.aspx");

        }
    }
}