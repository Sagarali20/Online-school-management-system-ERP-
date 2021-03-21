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
	public partial class _class : System.Web.UI.Page
	{
		Dbconnection cn = new Dbconnection();
		protected void Page_Load(object sender, EventArgs e)
		{
			string usr = Session["user_name"].ToString();

			string q = "select *from user_access_derive where pageid='1' and user_name='"+usr+"'";
			SqlCommand cmd = new SqlCommand(q, cn.GetConnection());

			SqlDataReader reader = cmd.ExecuteReader();
			string ck;
			while (reader.Read())
			{

				ck = reader["action"].ToString();
				if (ck == "insert")
				{
					insert.Enabled = true;
				}
				if (ck == "update")
				{
					update.Enabled = true;
				}
				if (ck == "delete")
				{
				     Delete.Enabled = true;
				}


			}
			cn.getClose();

		}

		protected void Button1_Click(object sender, EventArgs e)
		{

		}

        protected void Log_out_Click(object sender, EventArgs e)
        {
            Session.Remove("user_name");
            Response.Redirect("~/login.aspx");
        }
    }
}