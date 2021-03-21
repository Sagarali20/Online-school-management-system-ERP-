using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Final_project.view_Model_Student
{
    public class student_account_info
    {
        public int stdId { get; set; }
        public int Class { get; set; }      
        public   DateTime pmonth { get; set; }
        public int payable { get; set; }
        public int paid { get; set; }
        public int dues { get; set; }
        public DateTime Month { get; set; }
        public int Recpt { get; set; } 
    }
}