using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using Final_project.getway;

namespace Final_project.getway
{
    public class payment_Save
    {
        Dbconnection cn = new Dbconnection();
        public int save_month()
        {
            string stdid, classs;
            int cost,i=1,p=200;
            string pp = "bank", rr = "", tt = "1";
            string pdate = DateTime.Now.ToString();
            string q = "select promotion.Student_Id as studentid,promotion.Class as class,ClassCost.Cost as cost from promotion,ClassCost where promotion.Class = ClassCost.c_id ";
            SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
            SqlDataReader reade = cmd.ExecuteReader();
           
            while(reade.Read())
            {
                stdid = reade["studentid"].ToString();
                 classs = reade["class"].ToString();
                cost =Convert.ToInt32( reade["cost"].ToString());
                string l;
                l = "insert into Payment_Student(Studentid,Pmonth,payable,paid,pdate,paymethod,Money_Recpts,duestats,Class) values('"+stdid+"','"+pdate+"',"+cost+","+p+",'"+pdate+"','"+pp+"','"+rr+"','"+tt+"',"+classs+")";
                SqlCommand cmd1 = new SqlCommand(l,cn.GetConnection());
                cmd1.ExecuteNonQuery();

                 
            }
            return i;
        }
    }
}