using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_project
{
    public partial class Site2 : System.Web.UI.MasterPage
    {
        public int us1;
        protected void Page_Load(object sender, EventArgs e)
        {
            us1 = 9;
        }
    }
}