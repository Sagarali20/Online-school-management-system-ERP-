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
	public partial class table : System.Web.UI.Page
	{
		Dbconnection cn = new Dbconnection();
		protected void Page_Load(object sender, EventArgs e)
		{


		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			string q = "select *from user_derive";
			SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataSet td = new DataSet();
			//DataTable td = new DataTable();
			da.Fill(td);
			GridView1.DataSource = td;
			GridView1.DataBind();

		}
	}
}