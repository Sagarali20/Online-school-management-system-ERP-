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
    public partial class std_payment_entry : System.Web.UI.Page
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
            string q = "select *from user_access_derive where pageid='8' and user_name='" + usr + "'";
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
            string q = "select *from user_access_derive where pageid='8' and user_name='" + usr + "'";
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

        protected void insert_Click(object sender, EventArgs e)
        {
            Label5.Visible = true;
            DateTime dt;
            dt = Calendar1.SelectedDate;
            String query = "Insert into payment values(" + TextBox2.Text + ",'" +dt+"'," + TextBox5.Text + "," + DropDownList1.Text + "," + TextBox6.Text + ")";
            SqlCommand cmd = new SqlCommand(query, cn.GetConnection());
            Label5.Text = "insert has been successfully";
            cmd.ExecuteNonQuery();
            TextBox2.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            DropDownList1.Text = "";

        }

        protected void view_Click(object sender, EventArgs e)
        {
            alldata();
        }

        private void alldata()
        {
            string q = "select *from payment";
            SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            Repeater1.DataSource = dt;
            Repeater1.DataBind();
        }

        protected void Search_button_Click(object sender, EventArgs e)
        {
            insert.Enabled = false;
            view.Enabled = false;
            NewMethod2();
            string q = "select *from payment where stdid="+Searchtext.Text+ " and class="+DropDownList4.Text+ " and pmonth='"+TextBox1.Text+"'";
            SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                
                TextBox2.Text = reader["userid"].ToString();
                TextBox5.Text = reader["utype"].ToString();
                DropDownList1.Text = reader["user_name"].ToString();
                TextBox6.Text = reader["recepts_no"].ToString();


            }
            else
            {
                delete.Enabled = false;
                update.Enabled = false;

            }
            Repeater1.DataSource = dt;
            Repeater1.DataBind();

        }

        protected void delete_Click(object sender, EventArgs e)
        {
            Label5.Visible = true;
            string query = "delete from payment where stdid=" + Searchtext.Text + " and class=" + DropDownList4.Text + "";
            SqlCommand cmd = new SqlCommand(query, cn.GetConnection());

            cmd.ExecuteNonQuery();
            Label5.Text = "Delete data has been successfully";
            alldata();
            TextBox2.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            DropDownList1.Text = "";
            delete.Enabled = false;
            update.Enabled = false;
        }

        protected void update_Click(object sender, EventArgs e)
        {
            Label5.Visible = true;
            string query = "delete from payment where stdid=" + Searchtext.Text + " and class=" + DropDownList4.Text + "";
            SqlCommand cmd = new SqlCommand(query, cn.GetConnection());

            cmd.ExecuteNonQuery();
            DateTime dt;
            dt = Calendar1.SelectedDate;
            String query1 = "Insert into payment values(" + TextBox2.Text + ",'" + dt + "'," + TextBox5.Text + "," + DropDownList1.Text + "," + TextBox6.Text + ")";
            SqlCommand cmd1 = new SqlCommand(query1, cn.GetConnection());
            Label5.Text = "Update has been successfully!!!";
            cmd1.ExecuteNonQuery();
            alldata();
            TextBox2.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            DropDownList1.Text = "";
            delete.Enabled = false;
            update.Enabled = false;
        }

        protected void cancle_Click(object sender, EventArgs e)
        {
            TextBox2.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            DropDownList1.Text = "";
            delete.Enabled = false;
            update.Enabled = false;
        }
    }
}