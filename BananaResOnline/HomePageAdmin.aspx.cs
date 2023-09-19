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
    public partial class HomePageAdmin : System.Web.UI.Page
    {
        string con = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =";
        OleDbConnection myDb;
        protected void Page_Load(object sender, EventArgs e)
        {
            myDb = new OleDbConnection(con + "E:\\BananaResOnline\\Student_Databases.accdb");
           
        }

        protected void btnCheckApplicants_Click(object sender, EventArgs e)
        {
            lblSelect.Visible = true;
            radSelect.Visible = true;
            btnProceed.Visible = true;
           
        }

        protected void btnPlace_Click(object sender, EventArgs e)
        {
            Response.Redirect("PlacementForm.aspx");
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {

        }

        protected void btnProceed_Click(object sender, EventArgs e)
        {
            try
            {
                myDb.Open();
                if (radSelect.SelectedIndex == 0)
                {
                    OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT * FROM FirstYearStudentsDB", myDb);
                    DataTable dtbl = new DataTable();
                    adapter.Fill(dtbl);
                    GridView1.DataSource = dtbl;
                    GridView1.DataBind();
                }
                else
                {
                    OleDbDataAdapter adapter = new OleDbDataAdapter(@"SELECT * FROM SeniorStudentsDB", myDb);
                    DataTable dtbl = new DataTable();
                    adapter.Fill(dtbl);
                    GridView1.DataSource = dtbl;
                    GridView1.DataBind();
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                myDb.Close();
            }
            
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminLogIn.aspx");
        }
    }
}