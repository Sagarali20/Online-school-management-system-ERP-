
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_project
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Session["DaysAvailable"] = 25;
            }
        }

        protected void btnUpdateDays_Click(object sender, EventArgs e)
        {
            Session["DaysAvailable"] = 75;

        }
    }
}