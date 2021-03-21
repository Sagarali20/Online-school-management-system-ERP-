﻿using System;
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
        public string usr;
		protected void Page_Load(object sender, EventArgs e)
        {
             usr = Session["user_name"].ToString();
            NewMethod1();
            NewMethod();


        }

        private void NewMethod2()
        {
            //string usr = "sagarali";
            Label5.Visible = false;
            string q = "select *from user_access_derive where pageid='1' and user_name='" + usr + "'";
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
                    Delete.Enabled = true;
                }


            }
            cn.getClose();
        }

        private void NewMethod1()
        {
            //string usr = "sagarali";
            Label5.Visible = false;
            string q = "select *from user_access_derive where pageid='1' and user_name='" + usr + "'";
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

        private void NewMethod()
        {
            string q = "select *from class";
            SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet td = new DataSet();
            //DataTable td = new DataTable();
            da.Fill(td);
            Repeater1.DataSource = td;
            Repeater1.DataBind();
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

        protected void insert_Click(object sender, EventArgs e)
        {
            Label5.Visible = true;
            string act = "active";
            string q = "insert into class values(" + TextBox2.Text + ",'" + TextBox1.Text + "','" + DropDownList1.Text + "','" + act + "')";
            SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
            int i = cmd.ExecuteNonQuery();
            Label5.Text = "data  successfully";
            TextBox2.Text = "";
            TextBox1.Text = "";
            DropDownList1.Text = "";
            NewMethod();
        }

        protected void update_Click(object sender, EventArgs e)
        {
            string q = "delete from class where c_id="+ TextBox2.Text+ "";
            SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
            cmd.ExecuteNonQuery();
            cn.getClose();
            Label5.Visible = true;
            string act = "active";
            string q1 = "insert into class values(" + TextBox2.Text + ",'" + TextBox1.Text + "','" + DropDownList1.Text + "','" + act + "')";
            SqlCommand cmd1 = new SqlCommand(q1, cn.GetConnection());
            int i = cmd1.ExecuteNonQuery();
            Label5.Text = "data update  successfully";
            TextBox2.Text = "";
            TextBox1.Text = "";
            DropDownList1.Text = "";
            Delete.Enabled = false;
            update.Enabled = false;
            NewMethod();

        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            Label5.Visible = true;
          
            string q = "delete from class where c_id="+TextBox2.Text+"";
            SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
            int i = cmd.ExecuteNonQuery();
            Label5.Text = "delete has been successfully";
            TextBox2.Text = "";
            TextBox1.Text = "";
            DropDownList1.Text = "";
            Delete.Enabled = false;
            update.Enabled = false;
            NewMethod();
        }

        protected void Search_Click(object sender, EventArgs e)
        {
            insert.Enabled = false;
            NewMethod2();
            string q = "select *from class where C_id=" + text_search.Text + "";
            SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                TextBox2.Text = reader["C_id"].ToString();
                TextBox1.Text = reader["Name"].ToString();
                DropDownList1.Text = reader["C_lavel"].ToString();
           

            }
            cn.getClose();
            SqlCommand cmd2 = new SqlCommand(q, cn.GetConnection());
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Repeater1.DataSource = ds;
            Repeater1.DataBind();
        }

        protected void cancel_Click(object sender, EventArgs e)
        {
            Delete.Enabled = false;
            update.Enabled = false;
            TextBox2.Text = "";
            TextBox1.Text = "";
            DropDownList1.Text = "";
        }
    }
}