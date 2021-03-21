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
    public partial class All_staff_2 : System.Web.UI.Page
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
                    Class_le.Enabled = true;
                }
                if (ck == "2")
                {
                    subjectle.Enabled = true;
                }
                if (ck == "3")
                {
                    Addmisionle.Enabled = true;
                }
                if (ck == "4")
                {
                    resultle.Enabled = true;
                }
                if (ck == "5")
                {
                    promotionle.Enabled = true;
                }
                if (ck == "6")
                {
                    speciale.Enabled = true;

                }
                if (ck == "7")
                {
                    attendencele.Enabled = true;

                }
                if (ck == "8")
                {
                    accountpatmtdle.Enabled = true;
                }
                if (ck == "9")
                {

                   std_accounthstoryle.Enabled = true;
                }
                if (ck == "10")
                {
                    User_Detailsle.Enabled = true;
                }
                if (ck == "11")
                {
                    Create_Userle.Enabled = true;
                }
                if (ck == "12")
                {
                    ChangePasswordle.Enabled = true;
                }
                if (ck == "13")
                {
                    User_permissionle.Enabled = true;
                }
            }
        }
    }
}