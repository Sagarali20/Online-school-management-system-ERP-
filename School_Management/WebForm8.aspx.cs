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
    public partial class WebForm8 : System.Web.UI.Page
    {
        Dbconnection cn = new Dbconnection();
        protected void Page_Load(object sender, EventArgs e)
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
    }
}