using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Final_project.getway;

namespace Final_project.manager
{
    public class payment_month
    {
        public string save()
        {
            payment_Save ps = new payment_Save();
            int tc =  ps.save_month();


            return "";
        }
    }
}