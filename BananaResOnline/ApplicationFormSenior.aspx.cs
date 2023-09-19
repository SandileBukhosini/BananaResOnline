using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.IO;
using System.Data;

namespace BananaResOnline
{
    public partial class ApplicationFormSenior : System.Web.UI.Page
    {
        public OleDbConnection connection = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = E:\\BananaResOnline\\Student_Databases.accdb");
        public OleDbCommand com;
        public OleDbDataAdapter adapter;
        protected void Page_Load(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Today.ToShortDateString();
            txtAcademicYear.Text = (DateTime.Today.Year + 1).ToString();
            txtDate.Enabled = false;
            txtAcademicYear.Enabled = false;
        }
        public string LastName, FirstName, Gender, DateOfBirth, AcademicYear, TelephoneNumber, PostalAddress, DegreeType, OnCampusResName, OfCampusResName, DataOfApplication, StudentNumber;
        public int ResID;
        protected void Button1_Click(object sender, EventArgs e)
        {
            string Rname;
            DataOfApplication = txtDate.Text;
            LastName = txtLNames.Text;
            FirstName = txtFName.Text;
            StudentNumber = txtStNum.Text;
            Gender = txtGender.Text;
            DateOfBirth = txtDOB.Text;
            AcademicYear = txtAcademicYear.Text;
            TelephoneNumber = txtNum.Text;
            PostalAddress = txtAddress.Text;
            DegreeType = radDegree.SelectedValue.ToString(); ;
            int average = Convert.ToInt32(txtAverage.Text);
            Response.Cookies["Name"].Value = txtFName.Text;
            Response.Cookies["Res"].Value = RadioButtonList1.SelectedItem.Text;

            if (RadioButtonList1.SelectedIndex == 0)
            {
                ResID = 1;
            }
            else
               if (RadioButtonList1.SelectedIndex == 1)
            {
                ResID = 2;
            }
            else
               if (RadioButtonList1.SelectedIndex == 2)
            {
                ResID = 3;
            }
            else
               if (RadioButtonList1.SelectedIndex == 3)
            {
                ResID = 4;
            }
            else
               if (RadioButtonList1.SelectedIndex == 4)
            {
                ResID = 5;
            }
            else
               if (RadioButtonList1.SelectedIndex == 5)
            {
                ResID = 6;
            }
            else
               if (RadioButtonList1.SelectedIndex == 6)
            {
                ResID = 7;
            }
            else
               if (RadioButtonList1.SelectedIndex == 7)
            {
                ResID = 8;
            }
            else
               if (RadioButtonList1.SelectedIndex == 8)
            {
                ResID = 9;
            }
            else
               if (RadioButtonList1.SelectedIndex == 9)
            {
                ResID = 10;
            }


            if (FileResults.HasFile)
            {
                Rname = FileResults.PostedFile.FileName;
                
                string extension = Path.GetExtension(Rname);
                

                int Rsize = FileResults.PostedFile.ContentLength;
                

                int flag = 0;
                switch (extension.ToLower())
                {
                    case ".doc":
                    case ".docx":
                    case ".pdf":
                        flag = 1;
                        break;
                    default:
                        flag = 0;
                        break;

                }
                
                if (flag== 1)
                {
                    
                    FileResults.SaveAs(Server.MapPath("SeniorResults\\" + FileResults.FileName));
                }



                connection.Open();
                com = connection.CreateCommand();
                com.CommandType = System.Data.CommandType.Text;
                com.CommandText = "INSERT INTO SeniorStudentsDB VALUES('" + FirstName + "', '" + LastName + "', '" + StudentNumber + "', '" + DateOfBirth + "', '" + Gender + "', '" + AcademicYear + "', '" + TelephoneNumber + "', '" + PostalAddress + "', '" + DataOfApplication + "', '" + DegreeType + "','" + ResID + "', '" + average  + "', '" + Rname + "', '"+ txtEmail.Text+"')";
                com.ExecuteNonQuery();



                connection.Close();
                Response.Redirect("ApplicationConfirmation.aspx");
            }
            if (CheckBox1.Checked)
            {
                Response.Redirect("ApplicationConfirmation.aspx");
            }
            else
            {
                lblErrAuthentication.Visible = true;
            }
            
        }
    }
}