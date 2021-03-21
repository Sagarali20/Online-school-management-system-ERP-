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
	public partial class WebForm1 : System.Web.UI.Page
	{
        Dbconnection cn = new Dbconnection();
		protected void Page_Load(object sender, EventArgs e)
		{
            string usr = Session["user_name"].ToString();
            //  string usr="fh";
            string q = "select *from user_access_derive where user_name='" + usr + "'";
            SqlCommand cmd = new SqlCommand(q, cn.GetConnection());

            SqlDataReader reader = cmd.ExecuteReader();
            string ck;
            while (reader.Read())
            {

                ck = reader["pageid"].ToString();
                if (ck == "1")
                {
                    Class.Enabled = true;
                }
                if (ck == "2")
                {                  
                    Subject.Enabled = true;
                }
                if (ck == "3")
                {
                     Class_Section.Enabled = true;
                }
                if (ck == "4")
                {
                    Student_Admission.Enabled = true;
                }
                if (ck == "5")
                {
                    Student_result.Enabled = true;
                }
                if (ck == "6")
                {
                    Create_user.Enabled = true;
          
                }
                if (ck == "7")
                {
                    Change_password.Enabled = true;
                    
                }
                if (ck == "8")
                {
                    User_permission.Enabled = true;
                }
                if (ck == "9")
                {
                 
                    User_details.Enabled = true;
                }
            }

        }
	}
}