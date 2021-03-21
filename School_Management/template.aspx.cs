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
    public partial class template : System.Web.UI.Page
    {
        Dbconnection cn = new Dbconnection();
        public int alluser;
        protected void Page_Load(object sender, EventArgs e)
        {
            string q = "select *from user_derive";
            SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            alluser = dt.Rows.Count;
            cn.getClose();
            this.DataBind();

        }
    }
}