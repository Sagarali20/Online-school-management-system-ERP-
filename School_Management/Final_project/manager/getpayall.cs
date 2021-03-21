using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Final_project.getway;
using Final_project.view_Model_Student;

namespace Final_project.manager
{
    public class getpayall
    {
        getpayalls getpayalls = new getpayalls();
        public List<student_account_info> get(Int32 stdid)
        {
            return getpayalls.GetStudent_Account_Infos(stdid);
        }
        public List<student_account_info> payment_history(int stdid  )
        {
            return getpayalls.payment_history(stdid);
        }
        public  float parcen(string std)
        {

            return getpayalls.parcentance(std);
        }
        public List<Student_Class_history> Student_class_history( int stdid)
        {
            return getpayalls.Std_class_history(stdid);
        }
        public int login(int Std,string pass)
        {
            return getpayalls.login(Std,pass);
        }

    }
}