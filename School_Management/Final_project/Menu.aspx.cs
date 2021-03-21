using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using Final_project.getway;
namespace Final_project
{
	public partial class Menu : System.Web.UI.Page
	{
		Dbconnection cn = new Dbconnection();
		protected void Page_Load(object sender, EventArgs e)
		{
             string usr = Session["user_name"].ToString();
           
          //  string usr="fh";
			string q = "select *from user_access_derive where user_name='"+usr+"'";
			SqlCommand cmd = new SqlCommand(q, cn.GetConnection());

			SqlDataReader reader = cmd.ExecuteReader();
			string ck;
			while (reader.Read())
			{

				ck = reader["pageid"].ToString();
				if (ck == "1")
				{
					@class.Enabled = true;
				}
				if (ck == "2")
				{
				   subject.Enabled = true;
				}
				if (ck == "3")
				{
				    Class_section.Enabled = true;
				}
                if (ck == "4")
                {
                    student_info.Enabled = true;
                }
                if (ck == "5")
                {
                    Result.Enabled = true;
                }
                if (ck == "6")
                {
                    create_Account.Enabled = true;
                   
                }
                if (ck == "7")
                {
                    passWord_change.Enabled = true;
                }
                if (ck == "8")
                {
                     User_permission.Enabled = true;
                }
                if (ck == "9")
                {
                    user_info.Enabled = true;
                }


            }
			cn.getClose();

		}

		protected void class_Click(object sender, EventArgs e)
		{
			Response.Redirect("~/class.aspx");
		}

		protected void subject_Click(object sender, EventArgs e)
		{
			Response.Redirect("~/subject.aspx");
		}

		protected void Class_section_Click(object sender, EventArgs e)
		{
			Response.Redirect("~/class_section.aspx");
		}

		protected void Result_Click(object sender, EventArgs e)
		{
			Response.Redirect("~/result.aspx");

		}

		protected void create_Account_Click(object sender, EventArgs e)
		{
			Response.Redirect("~/create_user.aspx");
		}

		protected void passWord_change_Click(object sender, EventArgs e)
		{
			Response.Redirect("~/passWord_change.aspx");
		}

		protected void user_info_Click(object sender, EventArgs e)
		{
			Response.Redirect("~/employee_details.aspx");
		}

		protected void student_info_Click(object sender, EventArgs e)
		{
			Response.Redirect("~/student_info.aspx");
		}

        protected void Button5_Click(object sender, EventArgs e)
        {
            Session.Remove("user_name");
            Response.Redirect("~/login.aspx");

        }
    }
}