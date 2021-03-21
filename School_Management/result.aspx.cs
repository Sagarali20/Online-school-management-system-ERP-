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
	public partial class result : System.Web.UI.Page
	{
        string subject = null, type=null;
        Dbconnection cn = new Dbconnection();
        public string usr;
        protected void Page_Load(object sender, EventArgs e)
		{
            usr = Session["user_name"].ToString();
            Label5.Visible = false;
            NewMethod1();
          
        }
        private void NewMethod2()
        {
            //string usr = "sagarali";
            Label5.Visible = false;
            string q = "select *from user_access_derive where pageid='4' and user_name='" + usr + "'";
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
            string q = "select *from user_access_derive where pageid='4' and user_name='" + usr + "'";
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

        protected void log_out_Click(object sender, EventArgs e)
        {
            Session.Remove("user_name");
            Response.Redirect("~/login.aspx");
        }

        protected void insert_Click(object sender, EventArgs e)
        {

            int total=0;
            float p = 0f;
            string g="";
            int t =Convert.ToInt32(TextBox5.Text);
            int f = Convert.ToInt32(TextBox6.Text);
            total = t + f;
            if ((total >=80) && (total <=100))
            {
                g = "A+";
                p = 5.00f;
            }
            else if((total >= 70) && (total<= 79))
            {
                g = "A";
                p = 4.00f;
            }
            else if ((total >= 60) && (total <= 69))
            {
                g = "A-";
                p = 3.50f;
            }
            else if ((total >= 50) && (total <= 59))
            {
                g = "B";
                p = 3.00f;
            }
            else if ((total >= 40) && (total <= 49))
            {
                g = "C";
                p = 2.00f;
            }
            else if ((total >= 33) && (total <= 39))
            {
                g = "D";
                p = 1.00f;
            }
            else
            {
                g = "F";
                p = 0.00f;
            }


            string q = "insert into result values('" + TextBox2.Text + "','" + TextBox1.Text + "'," + DropDownList1.Text + ",'" + DropDownList3.Text + "','" + DropDownList2.Text + "'," + TextBox5.Text + "," + TextBox6.Text + "," +total+ ",'" + g + "',"+p+","+1+")";
            SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
            cmd.ExecuteNonQuery();
            cn.getClose();
            string q1 = "insert into Result_history values('" + TextBox2.Text + "','" + TextBox1.Text + "'," + DropDownList1.Text + ",'" + DropDownList3.Text + "','" + DropDownList2.Text + "'," + TextBox5.Text + "," + TextBox6.Text + "," + total + ",'" + g + "'," + p + "," + 1 + ")";
            SqlCommand cmd1 = new SqlCommand(q1, cn.GetConnection());
            cmd1.ExecuteNonQuery();
            cn.getClose();
          //  history(TextBox2.Text,  TextBox1.Text , Convert.ToInt16( DropDownList1.Text) ,  DropDownList3.Text , DropDownList2.Text ,Convert.ToInt16( TextBox5.Text) ,Convert.ToInt16( TextBox6.Text) ,total ,g, p );
        }

        protected void view_Click(object sender, EventArgs e)
        {
            string q = "select *from result";
            SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Repeater1.DataSource = ds;
            Repeater1.DataBind();

        }
        private void history( string sid,string tid,int clsid,string semster,string subname,int tumark,int finalmark,int total_mark,string  grade,float gpa)
        {

            string q = "insert into history values('" + sid + "','" + tid+ "'," +clsid+ ",'" + semster + "','" + subname + "'," +tumark + "," + finalmark + "," + total_mark + ",'" + grade + "'," + gpa + "," + 1 + ")";
            SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
            cmd.ExecuteNonQuery();
            cn.getClose();

        }

        protected void Search_button_Click(object sender, EventArgs e)
        {
            string q = "select *from result where s_id="+Searchtext.Text+" and class="+DropDownList4.Text+" and c_id='"+DropDownList5.Text+"'";
            SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
            SqlDataReader reader=cmd.ExecuteReader();
            if(reader.Read())
            {
                insert.Enabled = false;
                view.Enabled = false;
                TextBox2.Text = reader["s_id"].ToString();
                TextBox1.Text = reader["T_id"].ToString();
                TextBox5.Text = reader["tutorial_exam"].ToString();
                TextBox6.Text = reader["final_semester"].ToString();
                DropDownList1.Text = reader["class"].ToString();
                DropDownList3.Text = reader["exam_type"].ToString();


            }
            cn.getClose();
            SqlCommand cmd2 = new SqlCommand(q, cn.GetConnection());
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Repeater1.DataSource =ds;
            Repeater1.DataBind();
            NewMethod2();

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(DropDownList1.Text !="Class")
            {
                string q = "select s_name from subject where c_id=" + DropDownList1.Text + "";

                SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
                cmd.CommandType = CommandType.Text;
                DropDownList2.DataSource = cmd.ExecuteReader();
                DropDownList2.DataTextField = "S_name";
                //  DropDownList2.DataValueField = "Tid";
                DropDownList2.DataBind();
                DropDownList2.Items.Insert(0, new ListItem("Subject", "0"));

            }


        }

        protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(DropDownList4.Text !="Class")
            {
            string q = "select s_name from subject where c_id=" + DropDownList4.Text + "";
            SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
            cmd.CommandType = CommandType.Text;
            DropDownList5.DataSource = cmd.ExecuteReader();
            DropDownList5.DataTextField = "S_name";
            //  DropDownList2.DataValueField = "Tid";
            DropDownList5.DataBind();
            DropDownList5.Items.Insert(0, new ListItem("Subject", "0"));

            }


        }

        protected void delete_Click(object sender, EventArgs e)
        {

            string q = "delete from result where s_id=" + Searchtext.Text + " and exam_type='"+ DropDownList3.Text+"' and class=" + DropDownList4.Text + " and c_id='" + DropDownList5.Text + "'";
            SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
            cmd.ExecuteNonQuery();
            cn.getClose();
            string q1 = "delete from result_history where s_id=" + Searchtext.Text + " and exam_type='" + DropDownList3.Text + "' and class=" + DropDownList4.Text + " and c_id='" + DropDownList5.Text + "'";
            SqlCommand cmd1 = new SqlCommand(q1, cn.GetConnection());
            cmd1.ExecuteNonQuery();
            cn.getClose();
            delete.Enabled = false;
            update.Enabled = false;
        }

        protected void cancle_Click(object sender, EventArgs e)
        {
            delete.Enabled = false;
            update.Enabled = false;
        }

        protected void update_Click(object sender, EventArgs e)
        {
            int total = 0;
            float p = 0f;
            string g = "";
            int t = Convert.ToInt32(TextBox5.Text);
            int f = Convert.ToInt32(TextBox6.Text);
            total = t + f;
            if ((total >= 80) && (total <= 100))
            {
                g = "A+";
                p = 5.00f;
            }
            else if ((total >= 70) && (total <= 79))
            {
                g = "A";
                p = 4.00f;
            }
            else if ((total >= 60) && (total <= 69))
            {
                g = "A-";
                p = 3.50f;
            }
            else if ((total >= 50) && (total <= 59))
            {
                g = "B";
                p = 3.00f;
            }
            else if ((total >= 40) && (total <= 49))
            {
                g = "C";
                p = 2.00f;
            }
            else if ((total >= 33) && (total <= 39))
            {
                g = "D";
                p = 1.00f;
            }
            else
            { 
                g = "F";
                p = 0.00f;
            }
            string q = "delete from result where s_id=" + Searchtext.Text + " and exam_type='" + DropDownList3.Text + "' and class=" + DropDownList4.Text + " and c_id='" + DropDownList5.Text + "'";
            SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
            cmd.ExecuteNonQuery();
            cn.getClose();
            string q1 = "delete from result_history where s_id=" + Searchtext.Text + " and exam_type='" + DropDownList3.Text + "' and class=" + DropDownList4.Text + " and c_id='" + DropDownList5.Text + "'";
            SqlCommand cmd1 = new SqlCommand(q1, cn.GetConnection());
            cmd1.ExecuteNonQuery();
            cn.getClose();

            string q2 = "insert into result values('" + TextBox2.Text + "','" + TextBox1.Text + "'," + DropDownList1.Text + ",'" + DropDownList3.Text + "','" + DropDownList2.Text + "'," + TextBox5.Text + "," + TextBox6.Text + "," + total + ",'" + g + "'," + p + "," + 1 + ")";
            SqlCommand cmd2 = new SqlCommand(q2, cn.GetConnection());
            cmd2.ExecuteNonQuery();
            cn.getClose();
            string q3 = "insert into Result_history values('" + TextBox2.Text + "','" + TextBox1.Text + "'," + DropDownList1.Text + ",'" + DropDownList3.Text + "','" + DropDownList2.Text + "'," + TextBox5.Text + "," + TextBox6.Text + "," + total + ",'" + g + "'," + p + "," + 1 + ")";
            SqlCommand cmd3 = new SqlCommand(q3, cn.GetConnection());
            cmd3.ExecuteNonQuery();
            cn.getClose();
            delete.Enabled = false;
            update.Enabled = false;
        }
    }
}