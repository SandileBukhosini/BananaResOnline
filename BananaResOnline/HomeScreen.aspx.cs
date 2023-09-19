using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BananaResOnline
{
    public partial class HomeScreen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnApply_Click(object sender, EventArgs e)
        {
            radTypeStudent.Visible = true;
            btnContinue.Visible = true;
            lblStudent.Visible = true;

            Response.Write("<script>alert('Please have the copy of your results in hand before you start with your application.');</script>");
        }

        protected void btnContinue_Click(object sender, EventArgs e)
        {
            if(radTypeStudent.SelectedIndex == 0)
            {
                Response.Redirect("ApplicationFormSenior.aspx");
            }
            else
                if(radTypeStudent.SelectedIndex == 1)
            {
                Response.Redirect("ApplicationFormFirst.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ApplicationStatus.aspx");
        }

        protected void btnInstructions_Click(object sender, EventArgs e)
        {
            Response.Redirect("FormInstructions.aspx");
        }

        protected void btnSignOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("LogIn.aspx");
        }
    }
}