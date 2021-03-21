using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Final_project.manager;

namespace Final_project
{
    public partial class Payment_month : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            int monthNumber = 1; //1-12  
            string monthName = new System.Globalization.DateTimeFormatInfo().GetMonthName(monthNumber);

            string monthName1 = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(8);


          string sfg = DateTime.Now.ToString("dd-MMM-yyyy");


            // Get the current month integer.
            //
            DateTime now = DateTime.Now;
            //
            // Write the month integer and then the three-letter month.
            //
            Console.WriteLine(now.Month);
            Console.WriteLine(now.ToString("MMM"));

           string  ServerDate = DateTime.Now.ToString("yyyy-MM-dd");

            string now1 = DateTime.Now.ToString("MM-yy");

            payment_month p = new payment_month();
            string i=p.save();


        }
    }
}