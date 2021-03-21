using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Final_project.Model;
using System.Data.SqlClient;
using System.Data;
using Final_project.getway;

namespace Final_project
{
	public partial class passWord_Change : System.Web.UI.Page
	{
        Dbconnection cn = new Dbconnection();
        protected void Page_Load(object sender, EventArgs e)
		{
            Label5.Visible = false;

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Session.Remove("user_name");
            Response.Redirect("~/login.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string p = null;
            string s = "select *from User_derive where user_name='"+TextBox2.Text+"' and passWords='"+TextBox1.Text+"'";
            SqlCommand cmd1 = new SqlCommand(s, cn.GetConnection());
            SqlDataReader reader = cmd1.ExecuteReader();
            if (reader.Read())
            {
                if(TextBox4.Text==TextBox5.Text)
                {
                    Label5.Visible = true;
                    string q = "update user_derive set PassWords='"+TextBox5.Text+"' where User_name='"+TextBox2.Text+"'";
                    SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
                    int row = cmd.ExecuteNonQuery();
                    cn.getClose();
                    Label5.Text = "Password save has been successfully !!! ";
                }
                else
                {
                    Label5.Visible = true;
                    Label5.Text = "Invald new password";
                }


            }
            else
            {
                Label5.Visible = true;
                Label5.Text = "Invald old password/userName";
            }
            cn.getClose();


        }
    }
}