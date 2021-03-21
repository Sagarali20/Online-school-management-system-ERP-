using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Final_project.getway;
using Final_project.view_Model_Student;

namespace Final_project.getway
{
    public class getpayalls
    {
        Dbconnection cn = new Dbconnection();

        public  List<student_account_info> GetStudent_Account_Infos( Int32 stdid)
        {
            
            List<student_account_info> alist = new List<student_account_info>();
            string q1 = "SELECT  t2.stdId,t2.class,t2.pdate as Month,t2.pay as Payable,t1.paid as Paid,t2.pay-t1.paid as Dues,t1.paiddate FROM (select Stdid,FORMAT ( pdate , 'MM-yyyy' ) as pdate,pay,class from payable) t2 left JOIN(select t1.stdId,t1.paiddate,sum(t1.paid) as paid from(select Stdid,FORMAT ( pmonth , 'MM-yyyy' ) as paiddate,paid,class from payment group by stdId,class,paid,pmonth) t1 group by t1.stdId,t1.paiddate) t1 ON  t2.stdId=t1.stdId and t2.pdate=t1.paiddate where t2.stdId="+ stdid + " group by t2.stdId,t2.class,t2.pdate,t2.pay,t1.paid,t1.paiddate order by t1.paiddate";
            SqlCommand cmd1 = new SqlCommand(q1, cn.GetConnection());
            SqlDataReader reader = cmd1.ExecuteReader();
            while(reader.Read())
            {
                student_account_info student_Account_Info = new student_account_info();

                student_Account_Info.stdId = Convert.ToInt32(reader["stdId"].ToString());
                student_Account_Info.Class = Convert.ToInt32(reader["class"].ToString());
              //  student_Account_Info.paidmonth = Convert.ToDateTime(reader["paidmonth"]);

                student_Account_Info.pmonth = Convert.ToDateTime(reader["Month"] == DBNull.Value ? null : (DateTime?)Convert.ToDateTime(reader["month"]));
                //object v = (reader.IsDBNull(3) ? null : reader["paidmonth"]);
                //student_Account_Info.paidmonth = Convert.ToDateTime((DateTime?)v);
                //employee.FirstName = sqlreader[indexFirstName] as string;
                //employee.Age = sqlreader[indexAge] as int? ?? default(int);
              //  string s = reader["pmonth"].ToString();
                student_Account_Info.Month = Convert.ToDateTime(reader["Month"].ToString());
            
                
                student_Account_Info.payable = Convert.ToInt32(reader["payable"]);
                //d = Convert.ToDouble(reader["paid"] as float? ?? default(float));
                student_Account_Info.paid= reader["paid"] as Int32? ?? default(int);

                student_Account_Info.dues = reader["dues"] as int? ?? default(int);
                alist.Add(student_Account_Info);

            }
            return alist;
        }
        public List<student_account_info> payment_history(int stdId)
        {
            List<student_account_info> info = new List<student_account_info>();
            string q = "select Stdid,pmonth,paid,class,Recepts_no from  payment where stdId="+stdId+" group by Stdid,pmonth,paid,class,Recepts_no order by pmonth";
            SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            { 
                student_account_info student = new student_account_info();
                student.stdId = Convert.ToInt32(reader["stdId"].ToString());
                student.pmonth= Convert.ToDateTime(reader["pmonth"] == DBNull.Value ? null : (DateTime?)Convert.ToDateTime(reader["pmonth"]));
                student.paid = reader["paid"] as int? ?? default(int);
                student.Class =reader["class"] as int? ?? default(int);
                student.Recpt = Convert.ToInt32(reader["Recepts_no"].ToString());
                info.Add(student);
            }
            return info;
        }
        public float parcentance(string stdid)
        {
            int classs=0;
            string q = "select class from promotion where Student_Id='" + stdid + "'";
            SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                classs = Convert.ToInt32(reader["class"]);

            }
            cn.getClose();
            int  totalclass=0;
            string q1 = "select t1.class,count(t1.Adate) as totalClass from  (select class, Adate from Attendence_st group by Adate,class) t1 where class="+classs+" group by t1.class";
            SqlCommand cmd1 = new SqlCommand(q1, cn.GetConnection());
            SqlDataReader reader1 = cmd1.ExecuteReader();
            if (reader1.Read())
            {
                totalclass = Convert.ToInt32(reader1["totalClass"]);

            }
           
            float parcen = 0;
            string q2 = "select t1.sid,t1.class, cast(round(count(*)/"+totalclass+".0*100, 2)as numeric(8,2)) as percentage   from (select CAST(Adate as DATE) as t,sid,class,COUNT(*) as alls from attendence_st where Atten='true' group by CAST(Adate as DATE),Sid,class) t1 where t1.Sid='"+stdid+"' group by t1.Sid,t1.class";
            SqlCommand cmd2 = new SqlCommand(q2, cn.GetConnection());
            SqlDataReader reader2 = cmd2.ExecuteReader();
            if (reader2.Read())
            {
                parcen = Convert.ToSingle(reader2["percentage"]);

            }
            cn.getClose();

            return parcen;
        }
        public List< Student_Class_history> Std_class_history(int Stdid)
        {
            string q = "";
            SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
            SqlDataReader reader = cmd.ExecuteReader();
            List<Student_Class_history> list = new List<Student_Class_history>();
            while(reader.Read())
            {
                Student_Class_history alist = new Student_Class_history();
                alist.Stdid = Convert.ToInt32(reader["Student_id"]);
                alist.Class = Convert.ToInt32(reader["Class"]);
                alist.Class = Convert.ToInt32(reader["Roll_no"]);
                alist.Gpa = Convert.ToSingle(reader["Gpa"]);
                alist.Toatal_mark = Convert.ToInt32(reader["Total_Mark"]);
                list.Add(alist);
            }
            return list;
        }
        public int login(int stdid, string pass)
        {
            string act = "Active";
            int i=0;
            string q = "select *from student where St_id="+stdid+" and PassWord='"+pass+"' and St_type='"+act+"'";
            SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                 i = 1;
            }
 
            cn.getClose();
            return i;
        }


    }
}