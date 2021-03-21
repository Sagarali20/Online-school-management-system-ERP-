using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Final_project.getway;

namespace Final_project
{
	public partial class Create_User : System.Web.UI.Page
	{
		Dbconnection cn = new Dbconnection();
		public static int s;
		public  static int o = 0;
		
		protected void Page_Load(object sender, EventArgs e)
		{
            string usr = Session["user_name"].ToString();
     
            
            string q = "select *from user_access_derive where pageid='6' and user_name='" + usr + "'";
            SqlCommand cmd = new SqlCommand(q, cn.GetConnection());

            SqlDataReader reader = cmd.ExecuteReader();
            string ck;
            while (reader.Read())
            {

                ck = reader["action"].ToString();
                int I = 0;
                if (ck == "insert")
                {
                     AddNew.Enabled = true;
                }
                if (ck == "update")
                {
                    Update.Enabled = true;
                }
                if (ck == "permission")
                {
                    Permission.Enabled = true;
                }
                if (ck == "view")
                {
                     view.Enabled = true;
                }

            }
            cn.getClose();


        }

        protected void AddNew_Click(object sender, EventArgs e)
		{
			Save_user.Enabled = true;
			
			//string q = "select max(userId) as userid from user_derive";
			string q = "select  *from user_derive Order by(userid) desc;";

			SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
			SqlDataReader reader = cmd.ExecuteReader();
			if(reader.Read())
			{
			  s=Int32.Parse( reader["userid"].ToString());
				s++;
		
				TextBox2.Text = s.ToString();
			}
			else
			{
				s++;
				TextBox2.Text =s.ToString();
			}
			cn.getClose();
			
		 
		}

		protected void Save_user_Click(object sender, EventArgs e)
		{

			if (TextBox4.Text != TextBox5.Text)
			{

				Label5.Text = "Password doesn't matched, please check and try again.";
			}
			else
			{
				string jdate = DateTime.Today.ToString();
				string act = "active";
				string q = "insert into user_derive values('" + DropDownList1.Text  + "','"+ TextBox3.Text+"','" + TextBox4.Text + "','" + act + "','" + jdate + "')";
				SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
				int i = cmd.ExecuteNonQuery();
                Label5.Text = "Add user successfully";
				s++;
				TextBox2.Text = s.ToString();
			}
			cn.getClose();

		}

		protected void Update_Click(object sender, EventArgs e)
		{

		}

		protected void Permission_Click(object sender, EventArgs e)
		{
            Response.Redirect("~/permission_System.aspx");

		}

		protected void view_Click(object sender, EventArgs e)
		{
            string q = "select *from user_derive";
            SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet td = new DataSet();
            //DataTable td = new DataTable();
            da.Fill(td);
            GridView1.DataSource = td;
            GridView1.DataBind();
            cn.getClose();

        }

		protected void cancle_Click(object sender, EventArgs e)
		{

		}

        protected void Button5_Click(object sender, EventArgs e)
        {
            Session.Remove("user_name");
            Response.Redirect("~/login.aspx");
        }
    }
}