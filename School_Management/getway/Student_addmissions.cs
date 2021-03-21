using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Final_project.Model;
using System.Data.SqlClient;
using System.Data;
using Final_project.getway;
namespace Final_project.getway
{
    public class Student_addmissions
    {
        Dbconnection cn = new Dbconnection();

        public int saveadmit(Student_admission student)
        {
            Dbconnection cn = new Dbconnection();
            string adate = DateTime.Now.ToString();
            string ststus = "Active";
            string q = "insert into student values('" + student.Stdid + "','" + student.Sname + "','" + student.Fname + "','" + student.Mname + "','" + student.Class + "','" + student.Phone + "','" + student.Address + "','" + student.Birthdate + "','"+adate+"','" + student.Religion + "','" + student.Gender + "','"+ststus+"','" + student.Images + "','"+student.Password+ "')";
            SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
            int row = cmd.ExecuteNonQuery();
            cn.getClose();
            return row;
        }

        public string view(Student_admission student)
        {
            //Student_addmissions student_ = new Student_addmissions();
            string s = "select *from student where St_id='" + student.Stdid+ "'";
            SqlCommand cmd1 = new SqlCommand(s, cn.GetConnection());
            SqlDataReader reader = cmd1.ExecuteReader();
            if (reader.Read())
            {
                student.Stdid= reader["St_id"].ToString();
                student.Sname= reader["St_name"].ToString();
                student.Fname= reader["St_fname"].ToString();
                student.Mname= reader["St_mname"].ToString();
                student.Class =Convert.ToInt32(reader["St_class"]);
                student.Phone = reader["St_phone"].ToString();
                student.Address = reader["St_address"].ToString();
                student.Birthdate = Convert.ToDateTime( reader["St_date_of_birth"]);
                student.Religion = reader["St_Religion"].ToString();
                student.Gender = reader["St_gender"].ToString();
                student.Status = reader["St_type"].ToString();
                student.Images = reader["St_image"].ToString();

            }
            cn.getClose();
            return  student.Images;
        }

    }
}