using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Final_project.getway;
using Final_project.manager;

namespace Final_project
{
    public partial class Account_info : System.Web.UI.Page
    {
        Dbconnection cn = new Dbconnection();
        getpayall getpayall = new getpayall();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Search_Click(object sender, EventArgs e)
        {
            
            Repeater1.DataSource = getpayall.get(Convert.ToInt32(TextBox2.Text));
            Repeater1.DataBind();
            cn.getClose();

        }
    }
}