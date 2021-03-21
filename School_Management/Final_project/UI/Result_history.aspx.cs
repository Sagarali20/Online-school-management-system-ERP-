using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Final_project.getway;
using System.Data;
using System.Data.SqlClient;

namespace Final_project.UI
{
    public partial class Result_history : System.Web.UI.Page
    {
        Dbconnection cn = new Dbconnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            string q1 = "select exam_type from result group by exam_type order by exam_type desc";

            //SqlCommand cmd1 = new SqlCommand(q1, cn.GetConnection());
            //cmd1.CommandType = CommandType.Text;
            //DropDownList1.DataSource = cmd1.ExecuteReader();
            //DropDownList1.DataTextField = "exam_type";
            ////  DropDownList2.DataValueField = "Tid";
            //DropDownList1.DataBind();


            string stdid = Session["Student_id"].ToString();

            string q = "select *from Result where exam_type='" + DropDownList1.Text + "' and S_id="+stdid+"";
            SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Repeater1.DataSource = ds;
            Repeater1.DataBind();

        }


    }
}