using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Final_project.manager;

namespace Final_project.UI
{
    public partial class Progressbar : System.Web.UI.Page
    {
       
        getpayall per = new getpayall();
        public static float percen;
        protected void Page_Load(object sender, EventArgs e)
        {
            string stdid = Session["Student_id"].ToString();
            percen = per.parcen(stdid);
                
            Session["DaysAvailable"] = percen;
         
            Page.DataBind();

        }
    }
}