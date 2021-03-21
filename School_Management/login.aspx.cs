using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Final_project.getway;

namespace Final_project
{
	public partial class login : System.Web.UI.Page
	{
		Dbconnection cn = new Dbconnection();
		protected void Page_Load(object sender, EventArgs e)
		{
            Label1.Visible =false;
            //string s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\C#\Final_project\Final_project\App_Data\Final_Project.mdf;Integrated Security=True";
            //cn.ConnectionString = s;

        }

		protected void Button1_Click(object sender, EventArgs e)
		{

			string act = "active";
		     
			string q = "Select *from user_derive where User_name='" + TextBox1.Text + "' and PassWords='" + TextBox2.Text + "' and status='" + act + "'";
			SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
			SqlDataReader reader = cmd.ExecuteReader();
			if (reader.Read())
			{
			
				Session["user_name"] = TextBox1.Text;
				Response.Redirect("~/All_staff_2.aspx");

			}
			else
			{
				Label1.Visible = true;
				Label1.Text = "Invalid UserName/password";
			}
			cn.getClose();
		}

	}
	  
}