using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using Final_project.getway;
using Final_project.manager;

namespace Final_project
{
    public partial class WebForm7 : System.Web.UI.Page
    {

        Dbconnection cn = new Dbconnection();
        getpayall getpayall = new getpayall();
        protected void Page_Load(object sender, EventArgs e)
        {
            string stdid = Session["Student_id"].ToString();

            Repeater1.DataSource = getpayall.get(Convert.ToInt32(stdid));
            Repeater1.DataBind();
            cn.getClose();

        }
    }
}