using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using Final_project.getway;

namespace Final_project
{
	public partial class Employee : System.Web.UI.Page
	{
		Dbconnection cn = new Dbconnection();
		protected void Page_Load(object sender, EventArgs e)
		{

		}


		protected void Search_Click(object sender, EventArgs e)
        {
            NewMethod();

        }

        private void NewMethod()
        {
            string s = "select *from employee where userid='" + TextSearch.Text + "'";
            SqlCommand cmd1 = new SqlCommand(s, cn.GetConnection());
            SqlDataReader reader = cmd1.ExecuteReader();
            if (reader.Read())
            {
                Image1.ImageUrl = reader["images"].ToString();

            }
            cn.getClose();
        }

        protected void insert_Click(object sender, EventArgs e)
		{
			FileUpload1.SaveAs(Server.MapPath("~/imagesu/") + Path.GetFileName(FileUpload1.FileName));
			String link = "imagesu/" + Path.GetFileName(FileUpload1.FileName);
			String query = "Insert into employee(userid,name,father_name,mother_name,present_address,parnament_address,gender,national_id,email_id,phone_number,religion,images) values(" + TextBox1.Text + ",'"+TextBox2.Text+"','"+TextBox3.Text+ "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + DropDownList1.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + TextBox10.Text + "','" + TextBox11.Text + "','" + link + "')";
			SqlCommand cmd = new SqlCommand(query, cn.GetConnection());

			cmd.ExecuteNonQuery();

			string s = "select *from employee where userid='" + TextBox1.Text + "'";
			SqlCommand cmd1 = new SqlCommand(s, cn.GetConnection());
			SqlDataReader reader = cmd1.ExecuteReader();
			if (reader.Read())
			{
				Image1.ImageUrl = reader["images"].ToString();

			}
			cn.getClose();



		}

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {
            Session.Remove("user_name");
            Response.Redirect("~/login.aspx");
        }

        protected void view_Click(object sender, EventArgs e)
        {
            string q = "select *from employee";
            SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            Repeater1.DataSource = dt;
            Repeater1.DataBind();

        }
    }
}