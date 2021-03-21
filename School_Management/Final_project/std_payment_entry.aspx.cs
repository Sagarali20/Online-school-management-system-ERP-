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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void insert_Click(object sender, EventArgs e)
        {
            String query = "Insert into payment values(" + TextBox2.Text + ",'" +TextBox7.Text+"'," + TextBox5.Text + "," + DropDownList1.Text + "," + TextBox6.Text + ")";
            SqlCommand cmd = new SqlCommand(query, cn.GetConnection());
            
            cmd.ExecuteNonQuery();

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
            string q = "select *from payment where stdid="+Searchtext.Text+ " and class="+DropDownList4.Text+"";
            SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            Repeater1.DataSource = dt;
            Repeater1.DataBind();

        }

        protected void delete_Click(object sender, EventArgs e)
        {
            string query = "delete from payment where stdid=" + Searchtext.Text + " and class=" + DropDownList4.Text + "";
            SqlCommand cmd = new SqlCommand(query, cn.GetConnection());

            cmd.ExecuteNonQuery();
            alldata();
        }

        protected void update_Click(object sender, EventArgs e)
        {

        }
    }
}