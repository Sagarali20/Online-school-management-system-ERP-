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
    public partial class promotion : System.Web.UI.Page
    {
        Dbconnection cn = new Dbconnection();
        public static Int32 cid = 0,total=0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                all();
            }

        }

       

        protected void Promotions_Click(object sender, EventArgs e)
        {
            Label1.Visible = false;
            Label2.Visible = false;
            HyperLink1.Visible = false;
            if(DropDownList1.Text=="Class")
            {
                Label1.Visible = true;
                Label1.Text = "Please Select a Class !!!";

            }
            else
            {
                int c = Convert.ToInt32(DropDownList1.Text);
                c++;
                string q2 = "delete from promotion where class=" + c + "";
                SqlCommand cmd2 = new SqlCommand(q2, cn.GetConnection());
                cmd2.ExecuteNonQuery();
                int Roll_no, class_id, credit, total_mark, t = 0;
                string S_id = "";
                float Gpa = 0f, total_Gpa = 0f;
                double x = 0f;
                string q = " select  ROW_NUMBER() OVER (ORDER BY class) AS Roll_no, S_id,class,sum(GPA) as GPA,sum(credit) as total_credit,sum( total_mark) as Total_mark from result where not Grade='F' and class='" + DropDownList1.Text + "' group by S_id,class order by total_mark desc";
                SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    t++;
                    Roll_no = Convert.ToInt32(reader["Roll_no"].ToString());
                    S_id = reader["S_id"].ToString();
                    class_id = Convert.ToInt32(reader["class"].ToString());
                    Gpa = float.Parse(reader["GPA"].ToString());
                    credit = Convert.ToInt32(reader["total_credit"].ToString());
                    total_mark = Convert.ToInt32(reader["Total_mark"].ToString());
                    total_Gpa = (float)Gpa / credit;
                    x = Math.Round(total_Gpa, 2);

                    if (class_id == 6)
                    {
                        class_id = 7;
                    }
                    else if (class_id == 7)
                    {
                        class_id = 8;

                    }
                    else if (class_id == 8)
                    {
                        class_id = 9;
                    }

                    else if (class_id == 9)
                    {
                        class_id = 10;
                    }
                    try
                    {

                        string q1 = "insert into promotion values(" + Roll_no + ",'" + S_id + "'," + class_id + "," + x + "," + total_mark + ")";
                        SqlCommand cmd1 = new SqlCommand(q1, cn.GetConnection());
                        cmd1.ExecuteNonQuery();
                        cn.getClose();

                    }
                    catch
                    {
                        cid = class_id - 1;
                        total = total_mark;
                        Session["classs"] = class_id - 1;
                        Session["total_marks"] = total_mark;
                        string q3 = "delete from promotion where class=" + c + "";
                        SqlCommand cmd3 = new SqlCommand(q3, cn.GetConnection());
                        cmd3.ExecuteNonQuery();
                        Label2.Visible = true;
                        Label2.Text = "There are same number between two student";
                        HyperLink1.Visible = true;
                        Label1.Visible = false;
                        break;

                    }
                    insert(Roll_no, S_id, class_id, x, total_mark);

                    Label1.Visible = true;
                    Label1.Text = "Promotion has been successfully !!!";
                }

            }
            

            cn.getClose();
            all();
            
        }
         private void insert( int Roll_no,string Sid,int cid,double gpa,int total_mark)
        {
            Label2.Visible = false;
            HyperLink1.Visible = false;

            try
            {
                string q1 = "delete from History where Student_id='" + Sid + "' and class="+cid+"";
                SqlCommand cmd1 = new SqlCommand(q1,cn.GetConnection());
                cmd1.ExecuteNonQuery();

               string q = "insert into History values("+Roll_no+",'"+Sid+"',"+cid+","+gpa+","+total_mark+")";
               SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
               cmd.ExecuteNonQuery();
               cn.getClose();

            }
            catch
            {
              //  string q2 = "delete from promotion where class=" + cid + "";
              //  SqlCommand cmd2 = new SqlCommand(q2, cn.GetConnection());
              //  cmd2.ExecuteNonQuery();
                Label2.Visible = true;
                Label2.Text = "An error occoured in database";
                HyperLink1.Visible = true;

            }

        }
        private void all()
        {
            string q1 = "select *from promotion order by Class,Roll_no";
            SqlCommand cmd1 = new SqlCommand(q1, cn.GetConnection());
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataSet td = new DataSet();
            //DataTable td = new DataTable();
            da.Fill(td);
            Repeater1.DataSource = td;
            Repeater1.DataBind();
            cn.getClose();
        }
    }
}