using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Final_project.manager;
using Final_project.view_Model_Student;

namespace Final_project.UI
{
    public partial class Payment_history : System.Web.UI.Page
    {
        getpayall payment = new getpayall();
        protected void Page_Load(object sender, EventArgs e)
        {
            string stdid = Session["Student_id"].ToString();
            DateTime s = DateTime.Today;
            string d= s.Month.ToString();
            string m = DateTime.Today.ToString("mm");
            int t = d.Length;
            
            string o = d + m;
            int k = o.Length;
            Repeater1.DataSource = payment.payment_history(Convert.ToInt32(stdid));
            Repeater1.DataBind();


        }
    }
}