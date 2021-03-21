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
    public partial class Attendence_perfomance : System.Web.UI.Page
    {
        Dbconnection cn = new Dbconnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            int a = 15;
            string q = "select t1.sid,t1.class,cast(round(count(*)/" + a + ".0*100, 2)as numeric(8,2)) as percentage   from (select CAST(Adate as DATE) as t,sid,class,COUNT(*) as alls from attendence_st group by CAST(Adate as DATE),Sid,class) t1 group by t1.Sid,t1.class";
            // string q = "select t1.sid,t1.class,trunc(count(*)/" + a + ".0 as h)  from (select CAST(Adate as DATE) as t,sid,class,COUNT(*) as alls from attendence_st group by CAST(Adate as DATE),Sid,class) t1 group by t1.Sid,t1.class";
            SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
            final.DataSource = cmd.ExecuteReader();

            final.DataBind();
            cn.getClose();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.getClose();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {


        }
    }
}