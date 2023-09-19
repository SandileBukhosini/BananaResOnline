using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace BananaResOnline
{
    public partial class LogIn : System.Web.UI.Page
    {
        public string studNumber, password;
        OleDbConnection myDB;
        string con = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =";

        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cookies["StNumber"].Value = txtStNumber.Text;
        }

        protected void btnAdmin_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminLogin.aspx");
        }

        protected void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                myDB = new OleDbConnection(con + "E:\\BananaResOnline\\Students.accdb");
                myDB.Open();
                string checkUser = "Select count (*) from Students where stNumber = '" + txtStNumber.Text + "'";
                OleDbCommand com = new OleDbCommand(checkUser, myDB);
                int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
                myDB.Close();
                if (temp == 1)
                {
                    myDB.Open();
                    string checkPassword = "Select password from Students where stNumber = '" + txtStNumber.Text + "'";
                    OleDbCommand passCom = new OleDbCommand(checkPassword, myDB);
                    string password = passCom.ExecuteScalar().ToString();

                    if (password == txtPassword.Text)
                    {
                        Session["New"] = txtStNumber.Text;
                        Response.Write("<script>alert('Welcome to NWU online res application');</script>");
                        Response.Redirect("HomeScreen.aspx");
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
            catch (Exception ex)
            {

            }
            finally
            {
                myDB.Close();
            }
        }
    }
}