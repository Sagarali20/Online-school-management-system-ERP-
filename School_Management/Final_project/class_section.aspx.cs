using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_project
{
	public partial class class_section : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void log_out_Click(object sender, EventArgs e)
        {
            Session.Remove("user_name");
            Response.Redirect("~/login.aspx");
        }
    }
}