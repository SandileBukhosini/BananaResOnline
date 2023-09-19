using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BananaResOnline
{
    public partial class ApplicationStatus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Request.Cookies["Name"].Value;
            string res = Request.Cookies["Res"].Value;
            string stNum = Request.Cookies["StNumber"].Value;

            ListBox1.Items.Add("\t\t\t PO Box 1174, Vanderbijlpark");
            ListBox1.Items.Add("\t\t\t South Africa, 1900");
            ListBox1.Items.Add("\t\t\t Tel: (016) 910 - 3111");
            ListBox1.Items.Add("\t\t\t Web: http://www.nwu.ac.za");
            ListBox1.Items.Add("\t\t\t" + DateTime.Today);
            ListBox1.Items.Add(" ");
            ListBox1.Items.Add("University number: " + stNum);
            ListBox1.Items.Add(" ");
            ListBox1.Items.Add("Dear " + name);
            ListBox1.Items.Add(" ");
            ListBox1.Items.Add("Applications are still being processed, please check the status 3 weeks after the applications close");
            //ListBox1.Items.Add(" of placement, but comfirmation of receipt of your application.");
            ListBox1.Items.Add(" ");
            ListBox1.Items.Add("Regards");
            ListBox1.Items.Add("Residence admin");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomeScreen.aspx");
        }
    }
}