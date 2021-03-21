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
    public partial class WebForm5 : System.Web.UI.Page
    {
        Dbconnection cn = new Dbconnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                dropdown();
            }

        }
        private void dropdown()
        {
            string q = "select  Tid,class from Class_routine_teacher where tid='T001' group by  Tid,class order by Class asc";

            SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
            cmd.CommandType = CommandType.Text;
            DropDownList1.DataSource = cmd.ExecuteReader();
            DropDownList1.DataTextField = "class";
          //  DropDownList2.DataValueField = "Tid";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, new ListItem("Class", "0"));


           // ListItem nitem = new ListItem("select Class", "-1");
          //  DropDownList1.Items.Insert(0, nitem);
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(DropDownList1.SelectedIndex==0)
            {

            }
            else
            {
                string q = "select subjects,class from Class_routine_teacher where class=" + DropDownList1.SelectedItem + " and tid='T001' order by subjects" ;
                SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
                cmd.CommandType = CommandType.Text;
                DropDownList2.DataSource = cmd.ExecuteReader();
                DropDownList2.DataTextField = "subjects";
              //  DropDownList2.DataValueField = "class";
                DropDownList2.DataBind();
                DropDownList2.Items.Insert(0, new ListItem("Subject", "0"));

            }
        }

        protected void Promotions_Click(object sender, EventArgs e)
        {

            Label1.Visible = false;
            

            if (DropDownList1.SelectedIndex == 0 || DropDownList2.SelectedIndex==0)
            {
                Label1.Visible = true;
                Label1.Text = "Please select a class then subject !!!";
                final.DataSource = null;
                final.DataSourceID = null;
                final.DataBind();
            }
            else
            {
                //classs = Convert.ToInt32(DropDownList1.Text);
                string q1 = "select promotion.Student_Id,promotion.Roll_no,promotion.Class,Student.St_name from promotion,Student where promotion.Student_Id=Student.St_id and promotion.Class=" + DropDownList1.SelectedItem + " order by Roll_no;";
                SqlCommand cmd1 = new SqlCommand(q1, cn.GetConnection());
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataSet td = new DataSet();
                //DataTable td = new DataTable();
                da.Fill(td);
                final.DataSource = td;
                final.DataBind();
                cn.getClose();
            }
        }

        protected void final_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            string ck;
            int classs = Convert.ToInt32(DropDownList1.Text);
            

            foreach (RepeaterItem item in final.Items)
            {

                Label sid = (Label)item.FindControl("Std_id");
                string Sid = Convert.ToString(sid.Text);
                Label roll = (Label)item.FindControl("Roll");
                Int32 Roll = Convert.ToInt32(roll.Text);
                string adate = DateTime.Now.ToString();
                CheckBox chk = item.FindControl("chkSelect") as CheckBox;
                if (chk.Checked)
                {
                    ck = "true";
                }
                else
                {
                    ck = "false";
                }
                try
                {
                    string q = "insert into Attendence_st values(" + Sid + "," + Roll + ",'" + ck + "'," + classs + ",'" + DropDownList2.SelectedItem + "','" + adate + "')";
                    SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
                    cmd.ExecuteNonQuery();
                }
                catch
                {

                }
            }

        }
    }
}