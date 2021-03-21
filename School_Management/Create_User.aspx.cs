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
        public string usr;

        protected void Page_Load(object sender, EventArgs e)
		{
             usr = Session["user_name"].ToString();
            NewMethod1();


        }
        private void NewMethod2()
        {
            //string usr = "sagarali";
            Label5.Visible = false;
            string q = "select *from user_access_derive where pageid='11' and user_name='" + usr + "'";
            SqlCommand cmd = new SqlCommand(q, cn.GetConnection());

            SqlDataReader reader = cmd.ExecuteReader();
            string ck;
            while (reader.Read())
            {

                ck = reader["action"].ToString();

                if (ck == "update")
                {
                    Update.Enabled = true;
                }



            }
            cn.getClose();
        }

        private void NewMethod1()
        {
            //string usr = "sagarali";
            Label5.Visible = false;
            string q = "select *from user_access_derive where pageid='11' and user_name='" + usr + "'";
            SqlCommand cmd = new SqlCommand(q, cn.GetConnection());

            SqlDataReader reader = cmd.ExecuteReader();
            string ck;
            while (reader.Read())
            {

                ck = reader["action"].ToString();
                if (ck == "insert")
                {
                    AddNew.Enabled = true;
                }
                if (ck == "view")
                {
                    view.Enabled = true;
                }
                if (ck == "permission")
                {
                    Permission.Enabled = true;
                }


            }
            cn.getClose();
        }

        protected void AddNew_Click(object sender, EventArgs e)
		{
			Save_user.Enabled = true;
            AddNew.Enabled = false;
			
			////string q = "select max(userId) as userid from user_derive";
			//string q = "select  *from user_derive Order by(userid) desc;";

			//SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
			//SqlDataReader reader = cmd.ExecuteReader();
			//if(reader.Read())
			//{
			//  s=Int32.Parse( reader["userid"].ToString());
			//	s++;
		
			//	TextBox2.Text = s.ToString();
			//}
			//else
			//{
			//	s++;
			//	TextBox2.Text =s.ToString();
			//}
			//cn.getClose();
			
		 
		}

		protected void Save_user_Click(object sender, EventArgs e)
		{
            Label5.Visible = true;
            if (TextBox4.Text != TextBox5.Text)
			{

				Label5.Text = "Password doesn't matched, please check and try again.";
			}
			else
			{
				string jdate = DateTime.Today.ToString();
				string act = "active";
				string q = "insert into user_derive values("+TextBox2.Text+",'" + DropDownList1.Text  + "','"+ TextBox3.Text+"','" + TextBox4.Text + "','" + act + "','" + jdate + "')";
				SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
				int i = cmd.ExecuteNonQuery();
                Label5.Text = "Add user successfully";
				s++;
				TextBox2.Text = s.ToString();
			}
            Label5.Text = "Save has been successfully";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            DropDownList1.Text = "";
            cn.getClose();
            Save_user.Enabled = true;
        }

		protected void Update_Click(object sender, EventArgs e)
		{
            Label5.Visible = true;
            Save_user.Enabled = false;
            string q = "delete from user_derive where userid=" + TextBox1.Text + "";
            SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
            int i = cmd.ExecuteNonQuery();

            if (TextBox4.Text != TextBox5.Text)
            {

                Label5.Text = "Password doesn't matched, please check and try again.";
            }
            else
            {
                Update.Enabled = false;
                string jdate = DateTime.Today.ToString();
                string act = "active";
                string q1 = "insert into user_derive values(" + TextBox2.Text + ",'" + DropDownList1.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + act + "','" + jdate + "')";
                SqlCommand cmd1 = new SqlCommand(q1, cn.GetConnection());
                 cmd1.ExecuteNonQuery();
                Label5.Text = "Update user successfully";
                s++;
                TextBox2.Text = s.ToString();
                Save_user.Enabled = false;
            }
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            DropDownList1.Text = "";
            cn.getClose();

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
            Update.Enabled = false;
            Save_user.Enabled = false;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Session.Remove("user_name");
            Response.Redirect("~/login.aspx");
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            NewMethod2();
            Save_user.Enabled = false;
            AddNew.Enabled = false;
            view.Enabled = false;
   
            string q = "select *from user_derive where userid=" + TextBox1.Text + " ";
            SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {

                TextBox2.Text = reader["userid"].ToString();
                DropDownList1.Text = reader["utype"].ToString();
                TextBox3.Text = reader["user_name"].ToString();
                TextBox4.Text = reader["passwords"].ToString();


            }
            else
            {
                Update.Enabled = false;

            }
            GridView1.DataSource = dt;
            GridView1.DataBind();

        }
    }
}