using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Final_project.Model;
using Final_project.getway;

namespace Final_project.manager
{
    public class Student_Addmission
    {
        Student_addmissions students = new Student_addmissions();
        public string Saveadmit(Student_admission student)
        {
            int r=students.saveadmit(student);
            if(r>0)
            {
                return "ok";
            }
            return "No";
        }
        public string view( Student_admission student)
        {
            return students.view(student);
        }
    }
}