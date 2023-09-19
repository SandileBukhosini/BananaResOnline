using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;

namespace BananaResOnline
{
    public partial class RemoveStudents : System.Web.UI.Page
    {
        OleDbConnection myDB;
        protected void Page_Load(object sender, EventArgs e)
        {
            myDB = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = E:\\BananaResOnline\\Student_Databases.accdb");
        }

        public string studNum;
        protected void txtStudent_TextChanged(object sender, EventArgs e)
        {
            myDB.Open();
            studNum = txtStudent.Text;
            OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT * FROM FirstYearStudentsDB WHERE StudentNumber LIKE '%" + txtStudent.Text + "%'", myDB);
            OleDbDataAdapter adapter2 = new OleDbDataAdapter(@"SELECT * FROM SeniorStudentsDB WHERE StudentNumber LIKE '%" + txtStudent.Text + "%'", myDB);
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);
            adapter2.Fill(dtbl);
            GridView1.DataSource = dtbl;
            GridView1.DataBind();
            myDB.Close();
        }
        
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            myDB.Open();
            studNum = txtStudent.Text;
            OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT * FROM FirstYearStudentsDB WHERE StudentNumber LIKE '" + txtStudent.Text + "'", myDB);
            OleDbDataAdapter adapter2 = new OleDbDataAdapter(@"SELECT * FROM SeniorStudentsDB WHERE StudentNumber LIKE '%" + txtStudent.Text + "%'", myDB);
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);
            adapter2.Fill(dtbl);
            GridView1.DataSource = dtbl;
            GridView1.DataBind();
            myDB.Close();
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                myDB.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT * FROM FirstYearStudentsDB WHERE StudentNumber LIKE '" + txtStudent.Text + "'", myDB);
                OleDbDataAdapter adapter2 = new OleDbDataAdapter(@"SELECT * FROM SeniorStudentsDB WHERE StudentNumber LIKE '%" + txtStudent.Text + "%'", myDB);
                OleDbCommand sql = new OleDbCommand(@"DELETE FROM FirstYearStudentsDB WHERE StudentNumber = '" + txtStudent.Text + "'", myDB);
                OleDbCommand sql2 = new OleDbCommand(@"DELETE FROM SeniorStudentsDB WHERE StudentNumber = '" + txtStudent.Text + "'", myDB);
                adapter.DeleteCommand = sql;
                adapter2.DeleteCommand = sql2;
                int number = adapter.DeleteCommand.ExecuteNonQuery();
                int num = adapter2.DeleteCommand.ExecuteNonQuery();
                if (number > 0 && num > 0)
                {
                    Response.Write("<script>alert('Record has been deleted');</script>");
                    lblDelete.Text = "Student " + txtStudent.Text + " Has been deleted";
                }
                else
                {
                    Response.Write("<script>alert('Could not find record matching');</script>");
                }
                
            }
            catch (OleDbException ex)
            {
                Response.Write("<script>alert('Could not find record matching');</script>");
            }
            finally
            {
                myDB.Close();
            }

        }

        protected void txtReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("PlacementForm.aspx");
        }
    }
}