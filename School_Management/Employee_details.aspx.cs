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
            string q = "select *from user_access_derive where pageid='10' and user_name='" + usr + "'";
            SqlCommand cmd = new SqlCommand(q, cn.GetConnection());

            SqlDataReader reader = cmd.ExecuteReader();
            string ck;
            while (reader.Read())
            {

                ck = reader["action"].ToString();

                if (ck == "update")
                {
                    update.Enabled = true;
                }
                if (ck == "delete")
                {
                    delete.Enabled = true;
                }


            }
            cn.getClose();
        }

        private void NewMethod1()
        {
            //string usr = "sagarali";
            Label5.Visible = false;
            string q = "select *from user_access_derive where pageid='10' and user_name='" + usr + "'";
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
                if (ck == "view")
                {
                    view.Enabled = true;
                }



            }
            cn.getClose();
        }


        protected void Search_Click(object sender, EventArgs e)
        {
            NewMethod();
            NewMethod2();
            view.Enabled = false;

        }

        private void NewMethod()
        {

            string s = "select *from employee where userid='" + TextSearch.Text + "'";
            SqlCommand cmd1 = new SqlCommand(s, cn.GetConnection());
            SqlDataReader reader = cmd1.ExecuteReader();
            if (reader.Read())
            {
                NewMethod3();
                insert.Enabled = false;
                TextBox1.Text= reader["Userid"].ToString();
                TextBox2.Text = reader["Name"].ToString();
                TextBox3.Text = reader["father_name"].ToString();
                TextBox4.Text = reader["Mother_name"].ToString();
                TextBox5.Text = reader["present_address"].ToString();
                TextBox6.Text = reader["parnament_address"].ToString();
                DropDownList1.Text = reader["gender"].ToString();
                TextBox8.Text = reader["national_id"].ToString();
                TextBox9.Text = reader["Email_id"].ToString();
                TextBox10.Text = reader["Phone_number"].ToString();
                TextBox11.Text = reader["Religion"].ToString();

                Image1.ImageUrl = reader["images"].ToString();

            }
            cn.getClose();
        }

        protected void insert_Click(object sender, EventArgs e)
		{
            Label5.Visible = true;
            FileUpload1.SaveAs(Server.MapPath("~/imagesu/") + Path.GetFileName(FileUpload1.FileName));
			String link = "imagesu/" + Path.GetFileName(FileUpload1.FileName);
			String query = "Insert into employee(userid,name,father_name,mother_name,present_address,parnament_address,gender,national_id,email_id,phone_number,religion,images) values(" + TextBox1.Text + ",'"+TextBox2.Text+"','"+TextBox3.Text+ "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + DropDownList1.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + TextBox10.Text + "','" + TextBox11.Text + "','" + link + "')";
			SqlCommand cmd = new SqlCommand(query, cn.GetConnection());

			cmd.ExecuteNonQuery();
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
            TextBox10.Text = "";

            DropDownList1.Text = "";
            Label5.Text = "Add data has been successfully";


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
            NewMethod3();

        }

        private void NewMethod3()
        {
            string q = "select *from employee";
            SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            Repeater1.DataSource = dt;
            Repeater1.DataBind();
        }

        protected void update_Click(object sender, EventArgs e)
        {
            Label5.Visible = true;

            string q = "delete from employee where userid=" + TextBox1.Text + "";
            SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
            int i = cmd.ExecuteNonQuery();
            Label5.Text = "delete has been successfully";
            if (FileUpload1.FileName == "")
            {
                int h = 0;
            }
            else
            {
                FileUpload1.SaveAs(Server.MapPath("~/imagesu/") + Path.GetFileName(FileUpload1.FileName));
                String link = "imagesu/" + Path.GetFileName(FileUpload1.FileName);
                String query = "Insert into employee(userid,name,father_name,mother_name,present_address,parnament_address,gender,national_id,email_id,phone_number,religion,images) values(" + TextBox1.Text + ",'" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + DropDownList1.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + TextBox10.Text + "','" + TextBox11.Text + "','" + link + "')";
                SqlCommand cmd1 = new SqlCommand(query, cn.GetConnection());

                cmd1.ExecuteNonQuery();
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox6.Text = "";
                TextBox8.Text = "";
                TextBox9.Text = "";
                TextBox10.Text = "";

                DropDownList1.Text = "";
                Label5.Text = "Update data has been successfully";
            }
            delete.Enabled = false;
            update.Enabled = false;

        }

        protected void delete_Click(object sender, EventArgs e)
        {
            Label5.Visible = true;

            string q = "delete from employee where userid=" + TextSearch.Text + "";
            SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
            int i = cmd.ExecuteNonQuery();
            Label5.Text = "Delete has been successfully";
            TextBox2.Text = "";
            TextBox1.Text = "";
            DropDownList1.Text = "";
            delete.Enabled = false;
            update.Enabled = false;
            
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
            TextBox10.Text = "";

            DropDownList1.Text = "";

        }

        protected void cancle_Click(object sender, EventArgs e)
        {
            delete.Enabled = false;
            update.Enabled = false;

        }
    }
}