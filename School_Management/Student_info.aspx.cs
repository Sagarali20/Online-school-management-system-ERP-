using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using Final_project.Model;
using Final_project.manager;
using Final_project.getway;

namespace Final_project
{
	public partial class Admin_panel : System.Web.UI.Page
	{
        Student_admission Student = new Student_admission();
        Student_Addmission m = new Student_Addmission();
        Dbconnection cn = new Dbconnection();
        public string usr;
        protected void Page_Load(object sender, EventArgs e)

        {
            usr = Session["user_name"].ToString();
            Label5.Visible = false;
            NewMethod1();
            Image1.ImageUrl = "";
            alldata();

        }
        private void NewMethod2()
        {
            //string usr = "sagarali";
            Label5.Visible = false;
            string q = "select *from user_access_derive where pageid='3' and user_name='" + usr + "'";
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
            string q = "select *from user_access_derive where pageid='3' and user_name='" + usr + "'";
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



            }
            cn.getClose();
        }

        private void alldata()
        {
            string q = "select *from student";
            SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            Repeater1.DataSource = dt;
            Repeater1.DataBind();
        }

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {
            Session.Remove("user_name");
            Response.Redirect("~/login.aspx");
        }

        protected void insert_Click(object sender, EventArgs e)
        {
            
            Label5.Visible = true;
            if (FileUpload1.FileName=="")
            {
                int h = 0;
            }
            else
            {
                FileUpload1.SaveAs(Server.MapPath("~/imagesu/") + Path.GetFileName(FileUpload1.FileName));
                String link = "imagesu/" + Path.GetFileName(FileUpload1.FileName);
                Student.Stdid = TextBox1.Text;
                Student.Sname = TextBox2.Text;
                Student.Fname = TextBox3.Text;
                Student.Mname = TextBox4.Text;
                Student.Class = Convert.ToInt32(TextBox5.Text);
                Student.Phone = TextBox6.Text;
                Student.Address = TextBox8.Text;
                Student.Birthdate = Convert.ToDateTime(TextBox9.Text);
                Student.Religion = TextBox10.Text;
                Student.Gender = DropDownList1.Text;
                Student.Images = link;
                DateTime dateTime = Convert.ToDateTime(TextBox9.Text);
                string d = dateTime.Day.ToString();
                string mm = dateTime.Month.ToString();
                string y = dateTime.ToString("yy");
                string pass = d + mm + y;
                Student.Password = pass;
                string l = m.Saveadmit(Student);
                alldata();
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
            

            }
            string img = m.view(Student);
            Image1.ImageUrl = img;
            

        }

        protected void Search_Click(object sender, EventArgs e)
        {
            insert.Enabled = false;
            int std = Convert.ToInt32(TextSearch.Text);
            string q = "select *from student where st_id="+std+"";
            SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Repeater1.DataSource = dt;
            Repeater1.DataBind();

            Student.Stdid = TextSearch.Text;
            string img = m.view(Student);
            Image1.ImageUrl =Student.Images;
            TextBox1.Text = Student.Stdid;
            TextBox2.Text = Student.Sname;
            TextBox3.Text = Student.Fname;
            TextBox4.Text = Student.Mname;
            TextBox5.Text = Convert.ToString(Student.Class);
            TextBox6.Text = Student.Phone;
            TextBox8.Text = Student.Address;
            TextBox9.Text = Convert.ToString(Student.Birthdate);
            TextBox10.Text = Student.Religion;
            DropDownList1.Text = Student.Gender;
            if (Student.Sname!="")
            {
                NewMethod2();
            }


        }

        protected void update_Click(object sender, EventArgs e)
        {
            Label5.Visible = true;

            string q = "delete from student where st_id=" + TextBox1.Text + "";
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
                Student.Stdid = TextBox1.Text;
                Student.Sname = TextBox2.Text;
                Student.Fname = TextBox3.Text;
                Student.Mname = TextBox4.Text;
                Student.Class = Convert.ToInt32(TextBox5.Text);
                Student.Phone = TextBox6.Text;
                Student.Address = TextBox8.Text;
                Student.Birthdate = Convert.ToDateTime(TextBox9.Text);
                Student.Religion = TextBox10.Text;
                Student.Gender = DropDownList1.Text;
                Student.Images = link;
                DateTime dateTime = Convert.ToDateTime(TextBox9.Text);
                string d = dateTime.Day.ToString();
                string mm = dateTime.Month.ToString();
                string y = dateTime.ToString("yy");
                string pass = d + mm + y;
                Student.Password = pass;
                string l = m.Saveadmit(Student);
                alldata();
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
            string img = m.view(Student);
            Image1.ImageUrl = img;
            delete.Enabled = false;
            update.Enabled = false;
        }

        protected void delete_Click(object sender, EventArgs e)
        {
            Label5.Visible = true;

            string q = "delete from student where st_id=" + TextSearch.Text + "";
            SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
            int i = cmd.ExecuteNonQuery();
            Label5.Text = "delete has been successfully";
            TextBox2.Text = "";
            TextBox1.Text = "";
            DropDownList1.Text = "";
            delete.Enabled = false;
            update.Enabled = false;
            alldata();
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
            Label5.Text = "Delete data has been successfully";

        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }

        protected void cancle_Click(object sender, EventArgs e)
        {
            delete.Enabled = false;
            update.Enabled = false;
        }

        protected void TextSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}