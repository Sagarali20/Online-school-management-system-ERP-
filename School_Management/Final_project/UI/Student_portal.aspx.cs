using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Final_project.manager;
namespace Final_project
{
    public partial class Student_portal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "";
            getpayall getpayall = new getpayall();

            int i = getpayall.login(Convert.ToInt32(TextBox1.Text), TextBox2.Text);
            if (i > 0)
            {
                Session["Student_id"] = TextBox1.Text;
                Response.Redirect("~/UI/Homepage.aspx");
            }
            else
            {
                // Label1.Enabled = true;
                Label1.Visible = true;
                Label1.Text = "Invalid UserName/password";
            }
        }
    }
}