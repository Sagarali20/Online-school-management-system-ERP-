using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

using Final_project.getway;



namespace Final_project
{
    
    public partial class WebForm4 : System.Web.UI.Page
    {
        Dbconnection cn = new Dbconnection();

        public static Int32 classs;

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                SqlParameter para = new SqlParameter("@tid", "T001");
                DataSet ds = get("Tclass", para);
                DropDownList1.DataSource = ds;
                DropDownList1.Items.Clear();
              //  DropDownList1.Items.Add("--Selecct--");
                DropDownList1.DataTextField = "Class";
                DropDownList1.DataValueField = "Tid";
                DropDownList1.DataBind();

                ListItem nitem = new ListItem("select Class", "-1");
                DropDownList1.Items.Insert(0, nitem);
                ListItem nitem1 = new ListItem("select subject", "-1");
                DropDownList2.Items.Insert(0, nitem1);
            }





        }

        protected void View_All_Click(object sender, EventArgs e)
        {

        }

        protected void Search_button_Click(object sender, EventArgs e)
        {


        }

        protected void Promotions_Click(object sender, EventArgs e)
        {
            Label1.Visible = false;
            
            if (DropDownList1.Text=="Class")
            {
                Label1.Visible = true;
                Label1.Text = "Please select a class !!!";
                final.DataSource = null;
                final.DataSourceID = null;
                final.DataBind();
            }
            else
            {
             classs = Convert.ToInt32(DropDownList1.Text);
             string q1 = "select promotion.Student_Id,promotion.Roll_no,promotion.Class,Student.St_name from promotion,Student where promotion.Student_Id=Student.St_id and promotion.Class=" +classs+ " order by Roll_no;";
            SqlCommand cmd1 = new SqlCommand(q1, cn.GetConnection());
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataSet td = new DataSet();
            //DataTable td = new DataTable();
            da.Fill(td);
            final.DataSource = td;
            final.DataBind();
            cn.getClose();
            cn.getClose();

            }
            



        }


        protected void final_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            string ck;
            classs = Convert.ToInt32(DropDownList1.Text);
            string subjecct = "bangla";
    
            foreach (RepeaterItem item in final.Items)
            {

                Label sid = (Label)item.FindControl("Std_id");
                string Sid = Convert.ToString(sid.Text);
                Label roll = (Label)item.FindControl("Roll");
                Int32 Roll = Convert.ToInt32(roll.Text);
                string adate = DateTime.Now.ToString();
                CheckBox chk = item.FindControl("chkSelect") as CheckBox;  
                if(chk.Checked)
                {
                    ck = "true";
                }
                else
                {
                    ck = "false";
                }
                try
                {
                    string q = "insert into Attendence_st values(" + Sid + "," + Roll + ",'" + ck + "'," + classs + ",'"+subjecct+"','"+adate+"')";
                    SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    
                }
             


            }
        }
        private void insert(string student_id, int roll)
        {
            string ss = DateTime.Now.ToString();
            String date = DateTime.Now.Date.ToString();
            String Month = DateTime.Now.Month.ToString();
            String Year = DateTime.Now.Year.ToString();

        }

        private  DataSet get (string spname,SqlParameter tid )
        {
            SqlDataAdapter da = new SqlDataAdapter(spname, cn.GetConnection());
            da.SelectCommand.CommandType= CommandType.StoredProcedure;

            if(tid !=null)
            {
                da.SelectCommand.Parameters.Add(tid);
             
            }
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }



        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 0;

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 0;
        }
    }
}
  
    
