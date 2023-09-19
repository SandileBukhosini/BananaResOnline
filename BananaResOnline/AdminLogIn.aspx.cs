using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace BananaResOnline
{
    public partial class AdminLogIn : System.Web.UI.Page
    {
        string con = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogIn_Click(object sender, EventArgs e)
        {
            OleDbConnection myDB = new OleDbConnection(con + "E:\\BananaResOnline\\AdminDatabase.accdb");
            myDB.Open();
            string checkUser = "Select count (*) from Administrators where EmpNum = '" + txtEmpNum.Text + "'";
            OleDbCommand com = new OleDbCommand(checkUser, myDB);
            int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
            myDB.Close();
            if (temp == 1)
            {
                myDB.Open();
                string checkPassword = "Select Password from Administrators where EmpNum = '" + txtEmpNum.Text + "'";
                OleDbCommand passCom = new OleDbCommand(checkPassword, myDB);
                string password = passCom.ExecuteScalar().ToString();

                if (password == txtPassword.Text)
                {
                    Session["New"] = txtEmpNum.Text;
                    Response.Write("<script>alert('Welcome to NWU online res application');</script>");
                    Response.Redirect("HomePageAdmin.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Incorrect password');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Student number entered does not exist on our servers');</script>");
            }
        }

        protected void txtEmpNum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}