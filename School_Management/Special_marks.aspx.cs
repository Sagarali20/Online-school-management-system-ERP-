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
    public partial class Special_marks : System.Web.UI.Page
    {
        
        Dbconnection cn = new Dbconnection();
        Int32 cid = promotion.cid;
        Int32 total_mark = promotion.total;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if(!IsPostBack)
            {
                view();
            }
          
        }

        protected void insert_Click(object sender, EventArgs e)
        {
            Label5.Visible = false;
            int t=0,f=0;
            string tid = "001",type="spring",sub="Special_mark",g="A+";
            float p = 5f;
          //  string q = "insert into result values(" + TextBox1.Text + "," + 0001 + "," + classs + ",'" + "Spring"+ "','" + "special_mark" + "," + 0 + "," + 0 + "," + TextBox2.Text + ",'" +"A+" + "','" + 5.00 + "'," + "1"+ ")";
            string q = "insert into result values('" + DropDownList2.SelectedItem + "','" + tid + "'," + cid + ",'" + type + "','" + sub + "'," + t + "," + f + "," + TextBox2.Text + ",'" + g + "'," + p + "," + 1 + ")";

            SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
            cmd.ExecuteNonQuery();
            cn.getClose();
            view();
            TextBox2.Text = "";
            Label5.Visible = true;
            Label5.Text = "Insert has been successfully !!!";


        }

        protected void Search_button_Click(object sender, EventArgs e)
        {
            Label5.Visible = false;
            if(DropDownList1.SelectedIndex==0)
            {

                Label5.Visible = true;
                Label5.Text = "Please select Class";
            }
            else
            {
                string q = "select *from result where class=" + DropDownList1.Text + " and C_id='Special_mark'";
                SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Repeater1.DataSource = dt;
                Repeater1.DataBind();
                DropDownList2.Items.Clear();
                DropDownList2.DataSource = dt;
                DropDownList2.DataTextField = "s_id";
             
                DropDownList2.DataBind();
                DropDownList2.Items.Insert(0, new ListItem("Select_StdId", "0"));
                int c = dt.Rows.Count;
                if (c != 0)
                {
                    insert.Enabled = false;
                    update.Enabled = true;
                    delete.Enabled = true;
                    cancle.Enabled = true;
                }
                else
                {
                    insert.Enabled = true;
                    update.Enabled = false;
                    delete.Enabled = false;
                    cancle.Enabled = false;

                }
                TextBox2.Text = "";
            }

           
        }

        protected void delete_Click(object sender, EventArgs e)
        {
            Label5.Visible = false;
            string q = "delete from result where S_id='"+DropDownList2.SelectedItem+"' and c_id='Special_mark' ";
            SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
            cmd.ExecuteNonQuery();
            cn.getClose();
          
            TextBox2.Text = "";
            Label5.Visible = true;
            Label5.Text = "Delete has been successfully !!!";
            upview();

        }

        protected void update_Click(object sender, EventArgs e)
        {
            Label5.Visible = false;
           // string s = DropDownList2.SelectedIndex.;
            string q = "update result set total_mark='"+TextBox2.Text+"' where S_id='" + DropDownList2.SelectedItem+ "' and C_id='Special_mark'";
            SqlCommand cmd = new SqlCommand(q,cn.GetConnection());
            cmd.ExecuteNonQuery();
            cn.getClose();
         
            TextBox2.Text = "";
            Label5.Visible = true;
            Label5.Text = "Update has been successfully !!!";
            upview();

        }
        private void view()
        {
            string q = "select t2.s_id,t2.class,t2.Total_mark from (select  S_id,class,sum(GPA) as GPA,sum(credit) as total_credit,sum( total_mark) as Total_mark from result   where  not Grade='F'  and class=" + cid + "  group by S_id,class) t2 where  t2.Total_mark=" + total_mark + "";
            SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int c = dt.Rows.Count;
            if(c==1)
            {
                c = 1;
                Repeater1.DataSource =null;
                DropDownList2.Items.Clear();
                Repeater1.DataBind();
                  
                cn.getClose();
            }
            else
            {

                Repeater1.DataSource = dt;
                Repeater1.DataBind();
                DropDownList2.Items.Clear();
                DropDownList2.DataSource = dt;
                DropDownList2.DataTextField = "s_id";
              
                DropDownList2.DataBind();
                cn.getClose();

            }


        }

        protected void cancle_Click(object sender, EventArgs e)
        {
            insert.Enabled = true;
            update.Enabled = false;
            delete.Enabled = false;
            cancle.Enabled = false;
            //  Response.Redirect(Request.RawUrl);
            // Response.AppendHeader("Refresh", "10;Special_marks.aspx");
            //esponse.AppendHeader("Refresh", "2;");
            DropDownList2.Items.Clear();
            Repeater1.DataSource = null;
            Repeater1.DataBind();

            TextBox2.Text = "";
            Label5.Visible = false;
            view();
        }
         protected void upview()
        {

             string q = "select *from result where class=" + DropDownList1.Text + " and C_id='Special_mark'";
            SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Repeater1.DataSource = dt;
            Repeater1.DataBind();
            DropDownList2.Items.Clear();
            DropDownList2.DataSource = dt;
            DropDownList2.DataTextField = "s_id";
         
            DropDownList2.DataBind();
            int c = dt.Rows.Count;
            if (c != 0)
            {
                insert.Enabled = false;
                update.Enabled = true;
                delete.Enabled = true;
                cancle.Enabled = true;
            }
            else
            {
                insert.Enabled = true;
                update.Enabled = false;
                delete.Enabled = false;
                cancle.Enabled = false;

            }
            TextBox2.Text = "";

        }
    }
}