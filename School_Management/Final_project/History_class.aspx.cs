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
    public partial class History_class : System.Web.UI.Page
    {
        Dbconnection cn = new Dbconnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                all();
            }

        }
        private void all()
        {
            string q1 = "select *from History order by class desc,Student_id desc";
            SqlCommand cmd1 = new SqlCommand(q1, cn.GetConnection());
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataSet td = new DataSet();
            //DataTable td = new DataTable();
            da.Fill(td);
            Repeater1.DataSource = td;
            Repeater1.DataBind();
            cn.getClose();
        }


        protected void Search_button_Click(object sender, EventArgs e)
        {
            Repeater1.DataSource = null;
            Repeater1.DataBind();
            string q = "select *from history where Student_id='" + Searchtext.Text + "'";
            SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet td = new DataSet();
            //DataTable td = new DataTable();
            da.Fill(td);
            Repeater1.DataSource = td;
            Repeater1.DataBind();
            cn.getClose();

        }



        protected void View_All_Click(object sender, EventArgs e)
        {
            all();
        }
    }
}