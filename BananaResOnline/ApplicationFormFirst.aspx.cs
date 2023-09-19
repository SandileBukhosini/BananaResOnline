using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.IO;
using System.Data;
using System.Net;
using System.Net.Mail;

namespace BananaResOnline
{
    public partial class ApplicationFormFirst : System.Web.UI.Page
    {
        public OleDbConnection connection = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = E:\\BananaResOnline\\Student_Databases.accdb");
        public OleDbCommand com;
        public OleDbDataAdapter adapter;

        protected void Page_Load(object sender, EventArgs e)
        {
            txtDate1stYear.Text = DateTime.Today.ToShortDateString();
            txtAcademicYear.Text = (DateTime.Today.Year + 1).ToString();
            
            
        }

        public string LastName, FirstName,  Gender, DateOfBirth, AcademicYear, TelephoneNumber, PostalAddress,DegreeType,OnCampusResName,OfCampusResName,DataOfApplication, StudentNumber, EmailAddress;
        public int ResID, gradeAverage;

        
        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            DataOfApplication = txtDate1stYear.Text;
            LastName = txtLName.Text;
            FirstName = txtFNames.Text;
            StudentNumber =  txtStNum.Text;
            Gender = txtGender.Text;
            DateOfBirth = txtDOB.Text;
            AcademicYear = txtAcademicYear.Text;
            TelephoneNumber = txtNum.Text;
            PostalAddress = txtAddress.Text;
            DegreeType = txtDegree.Text;
            gradeAverage = Convert.ToInt32(txtAverage.Text);
            EmailAddress = txtEmail.Text;
            Response.Cookies["Name"].Value = txtLName.Text;
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

            if (FileResults.HasFile && FilePayment.HasFile)
            {
                string Rname = FileResults.PostedFile.FileName;
                string Pname = FilePayment.PostedFile.FileName;
                string extension = Path.GetExtension(Rname);
                string extension1 = Path.GetExtension(Pname);

                int Rsize = FileResults.PostedFile.ContentLength;
                int Psize = FilePayment.PostedFile.ContentLength;

                int flag = 0;
                switch (extension.ToLower())
                {
                    case ".doc":
                    case ".docx":
                    case ".pdf":
                    case ".png":
                    case ".jpg":
                        flag = 1;
                        break;
                    default:
                        flag = 0;
                        break;

                }
                switch (extension1.ToLower())
                {
                    case ".doc":
                    case ".docx":
                    case ".pdf":
                    case ".png":
                    case ".jpg":
                        flag = 1;
                        break;
                    default:
                        flag = 0;
                        break;

                }
                if (flag > 0 && flag <= 2)
                {
                    FilePayment.SaveAs(Server.MapPath("Payments\\" + FilePayment.FileName));
                    FileResults.SaveAs(Server.MapPath("Results\\" + FileResults.FileName));
                }



                connection.Open();
                com = connection.CreateCommand();
                com.CommandType = System.Data.CommandType.Text;
                com.CommandText = "INSERT INTO FirstYearStudentsDB  VALUES('" + FirstName + "', '" + LastName + "', '" + DateOfBirth + "', '" + StudentNumber + "', '" + AcademicYear + "', '" + Gender + "', '" + TelephoneNumber + "', '" + PostalAddress + "', '" + DataOfApplication + "', '" + DegreeType + "','" + ResID + "', '" + gradeAverage + "', '" + Rname + "', '" + Pname + "', '"+ EmailAddress +"')";
                com.ExecuteNonQuery();



                connection.Close();
                Response.Redirect("ApplicationConfirmation.aspx");
            }

           
            
        }

        
    }
}