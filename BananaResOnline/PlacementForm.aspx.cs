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
    public partial class PlacementForm : System.Web.UI.Page
    {
        string con = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =";
        OleDbConnection myDB;
        protected void Page_Load(object sender, EventArgs e)
        {
            myDB = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = E:\\BananaResOnline\\Student_Databases.accdb");
        }

        protected void btnPlace_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter adapter;
            OleDbDataAdapter adapter2;
            int roomsAvailable = 10;
            //string query = "SELECT * From FirstYearStudentsDB ORDER BY" + " GradeAverage";
            if (RadioButtonList1.SelectedIndex == 0)
            {
                try
                {
                    myDB.Open();
                    adapter = new OleDbDataAdapter(@"SELECT TOP " + roomsAvailable + " * FROM FirstYearStudentsDB WHERE ResID =" + 1 + "" + " ORDER BY GradeAverage DESC", myDB);
                    adapter2 = new OleDbDataAdapter(@"SELECT TOP " + roomsAvailable + " * FROM SeniorStudentsDB WHERE ResID =" + 1 + "" + " ORDER BY GradeAverage DESC", myDB);
                    DataTable dtbl = new DataTable();
                    adapter.Fill(dtbl);
                    adapter2.Fill(dtbl);
                    GridView1.DataSource = dtbl;
                    GridView1.DataBind();
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    myDB.Close();
                }
            }
            else
            if (RadioButtonList1.SelectedIndex == 1)
            {
                try
                {
                    myDB.Open();
                    adapter = new OleDbDataAdapter(@"SELECT TOP " + roomsAvailable + " * FROM FirstYearStudentsDB WHERE ResID =" + 2 + "" + " ORDER BY GradeAverage DESC", myDB);
                    adapter2 = new OleDbDataAdapter(@"SELECT TOP " + roomsAvailable + " * FROM SeniorStudentsDB WHERE ResID =" + 2 + "" + " ORDER BY GradeAverage DESC", myDB);
                    DataTable dtbl = new DataTable();
                    adapter.Fill(dtbl);
                    adapter2.Fill(dtbl);
                    GridView1.DataSource = dtbl;
                    GridView1.DataBind();
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    myDB.Close();
                }
            }
            if (RadioButtonList1.SelectedIndex == 2)
            {
                try
                {
                    myDB.Open();
                    adapter = new OleDbDataAdapter(@"SELECT TOP " + roomsAvailable + " * FROM FirstYearStudentsDB WHERE ResID =" + 3 + "" + " ORDER BY GradeAverage DESC", myDB);
                    adapter2 = new OleDbDataAdapter(@"SELECT TOP " + roomsAvailable + " * FROM SeniorStudentsDB WHERE ResID =" + 3 + "" + " ORDER BY GradeAverage DESC", myDB);
                    DataTable dtbl = new DataTable();
                    adapter.Fill(dtbl);
                    adapter2.Fill(dtbl);
                    GridView1.DataSource = dtbl;
                    GridView1.DataBind();
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    myDB.Close();
                }
            }
            if (RadioButtonList1.SelectedIndex == 3)
            {
                try
                {
                    myDB.Open();
                    adapter = new OleDbDataAdapter(@"SELECT TOP " + roomsAvailable + " * FROM FirstYearStudentsDB WHERE ResID =" + 4 + "" + " ORDER BY GradeAverage DESC", myDB);
                    adapter2 = new OleDbDataAdapter(@"SELECT TOP " + roomsAvailable + " * FROM SeniorStudentsDB WHERE ResID =" + 4 + "" + " ORDER BY GradeAverage DESC", myDB);
                    DataTable dtbl = new DataTable();
                    adapter.Fill(dtbl);
                    adapter2.Fill(dtbl);
                    GridView1.DataSource = dtbl;
                    GridView1.DataBind();
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    myDB.Close();
                }
            }
            if (RadioButtonList1.SelectedIndex == 4)
            {
                try
                {
                    adapter = new OleDbDataAdapter(@"SELECT TOP " + roomsAvailable + " * FROM FirstYearStudentsDB WHERE ResID =" + 5 + "" + " ORDER BY GradeAverage DESC", myDB);
                    adapter2 = new OleDbDataAdapter(@"SELECT TOP " + roomsAvailable + " * FROM SeniorStudentsDB WHERE ResID =" + 5 + "" + " ORDER BY GradeAverage DESC", myDB);
                    DataTable dtbl = new DataTable();
                    adapter.Fill(dtbl);
                    adapter2.Fill(dtbl);
                    GridView1.DataSource = dtbl;
                    GridView1.DataBind();
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    myDB.Close();
                }
            }
            if (RadioButtonList1.SelectedIndex == 5)
            {
                try
                {
                    adapter = new OleDbDataAdapter(@"SELECT TOP " + roomsAvailable + " * FROM FirstYearStudentsDB WHERE ResID =" + 6 + "" + " ORDER BY GradeAverage DESC", myDB);
                    adapter2 = new OleDbDataAdapter(@"SELECT TOP " + roomsAvailable + " * FROM SeniorStudentsDB WHERE ResID =" + 6 + "" + " ORDER BY GradeAverage DESC", myDB);
                    DataTable dtbl = new DataTable();
                    adapter.Fill(dtbl);
                    adapter2.Fill(dtbl);
                    GridView1.DataSource = dtbl;
                    GridView1.DataBind();
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    myDB.Close();
                }
            }
            if (RadioButtonList1.SelectedIndex == 6)
            {
                try
                {
                    myDB.Open();
                    adapter = new OleDbDataAdapter(@"SELECT TOP " + roomsAvailable + " * FROM FirstYearStudentsDB WHERE ResID =" + 7 + "" + " ORDER BY GradeAverage DESC", myDB);
                    adapter2 = new OleDbDataAdapter(@"SELECT TOP " + roomsAvailable + " * FROM SeniorStudentsDB WHERE ResID =" + 7 + "" + " ORDER BY GradeAverage DESC", myDB);
                    DataTable dtbl = new DataTable();
                    adapter.Fill(dtbl);
                    adapter2.Fill(dtbl);
                    GridView1.DataSource = dtbl;
                    GridView1.DataBind();
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    myDB.Close();
                }
            }
            if (RadioButtonList1.SelectedIndex == 7)
            {
                try
                {
                    myDB.Open();
                    adapter = new OleDbDataAdapter(@"SELECT TOP " + roomsAvailable + " * FROM FirstYearStudentsDB WHERE ResID =" + 8 + "" + " ORDER BY GradeAverage DESC", myDB);
                    adapter2 = new OleDbDataAdapter(@"SELECT TOP " + roomsAvailable + " * FROM SeniorStudentsDB WHERE ResID =" + 8 + "" + " ORDER BY GradeAverage DESC", myDB);
                    DataTable dtbl = new DataTable();
                    adapter.Fill(dtbl);
                    adapter2.Fill(dtbl);
                    GridView1.DataSource = dtbl;
                    GridView1.DataBind();
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    myDB.Close();
                }
            }
            if (RadioButtonList1.SelectedIndex == 8)
            {
                try
                {
                    adapter = new OleDbDataAdapter(@"SELECT TOP " + roomsAvailable + " * FROM FirstYearStudentsDB WHERE ResID =" + 9 + "" + " ORDER BY GradeAverage DESC", myDB);
                    adapter2 = new OleDbDataAdapter(@"SELECT TOP " + roomsAvailable + " * FROM SeniorStudentsDB WHERE ResID =" + 9 + "" + " ORDER BY GradeAverage DESC", myDB);
                    DataTable dtbl = new DataTable();
                    adapter.Fill(dtbl);
                    adapter2.Fill(dtbl);
                    GridView1.DataSource = dtbl;
                    GridView1.DataBind();
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    myDB.Close();
                }
            }
            if (RadioButtonList1.SelectedIndex == 9)
            {
                try
                {
                    adapter = new OleDbDataAdapter(@"SELECT TOP " + roomsAvailable + " * FROM FirstYearStudentsDB WHERE ResID =" + 10 + "" + " ORDER BY GradeAverage DESC", myDB);
                    adapter2 = new OleDbDataAdapter(@"SELECT TOP " + roomsAvailable + " * FROM SeniorStudentsDB WHERE ResID =" + 10 + "" + " ORDER BY GradeAverage DESC", myDB);
                    DataTable dtbl = new DataTable();
                    adapter.Fill(dtbl);
                    adapter2.Fill(dtbl);
                    GridView1.DataSource = dtbl;
                    GridView1.DataBind();
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

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            Response.Redirect("RemoveStudents.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void txtReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePageAdmin.aspx");
        }
    }
}