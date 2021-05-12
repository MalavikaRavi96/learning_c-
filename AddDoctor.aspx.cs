using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace TestProject
{
    public partial class AddDoctor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownDGender.Items.Add(" ");
                DropDownDGender.Items.Add("F");
                DropDownDGender.Items.Add("M");
                DropDownDGender.Items.Add("T");
                DropDownDGender.Items.Add(" ");
                DropDownSpecial.Items.Add("GYNACOLOGIST");
                DropDownSpecial.Items.Add("OPHTHALMOLOGIST");
                DropDownSpecial.Items.Add("CARDIOLOGIST");
                DropDownSpecial.Items.Add("EMERGENCY");
                //SQLHelper database connect panni datatable kondu vanthu session kulla store pannanum
                if (Session["DoctTable"] == null)
                {
                    DataTable dt = SQLHelp.GetDocData();
                    DataSet ds = new DataSet();
                    ds.Tables.Add(dt);
                    Session["TableDB_Dataset"] = ds;
                    Session["DoctTable"] = dt;
                }
            }
        }

        protected void BtnAddDDetails_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)Session["DoctTable"];
            
            try
            {
               if (dt == null)
                {
                    lbloutputs.Text = "<h2>Doctor Data not found</h3>";
                    return;

                }
                DataRow doc_dr = null;

                if (TextBoxID.Text != "")

                    doc_dr = dt.Rows.Find(int.Parse(TextBoxID.Text));
                if (doc_dr != null)
                {
                    lbloutputs.Text = "<h3>ERROR!!!!Duplicate Record</h3>";
                    return;
                }
                else
                {
                    doc_dr = dt.NewRow();
                    doc_dr[0] = int.Parse(TextBoxID.Text);
                    doc_dr[1] = TextBoxDName.Text;
                    doc_dr[2] = TextBoxDDOB.Text;
                    doc_dr[3] = TextBoxSS.Text;
                    doc_dr[4] = DropDownSpecial.Text.ToString();
                    doc_dr[5] = TextBoxContNo.Text;
                    doc_dr[6] = TextBoxDept.Text;
                    doc_dr[7] = DropDownDGender.Text.ToString();
                    dt.Rows.Add(doc_dr);
                    lbloutputs.Text += "<h3>Row Inserted </h3>" + $"<p>Count:{dt.Rows.Count}</p>";


                }
            }
            catch (SqlException err)
            {
                lbloutputs.Text = $"<h3>ERROR!!!!{err.Message}</h3>";
            }
        }

        protected void BtnCheck_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = null;
            try
            {
                DataTable dt = (DataTable)Session["DoctTable"];
                if (dt == null)
                {
                    lbloutputs.Text = "Doctor data not found";
                    return;

                }
                DataRow doc_dr = dt.Rows.Find(int.Parse(TextBoxID.Text));
                if (doc_dr != null)
                {
                    TextBoxDName.Text = doc_dr[1].ToString();
                    TextBoxDDOB.Text = doc_dr[2].ToString();
                    TextBoxSS.Text = doc_dr[3].ToString();
                    DropDownSpecial.Text= doc_dr[4].ToString();
                    TextBoxContNo.Text = doc_dr[5].ToString();
                    TextBoxDept.Text = doc_dr[6].ToString();
                    DropDownDGender.Text = doc_dr[7].ToString();
                }
                else
                {
                    lbloutputs.Text = $"<h3>ERROR!!!Doctor Data not found</h3>";
                }
            }
            catch (SqlException err)
            {
                lbloutputs.Text = $"<h3>ERROR!!!!{err.Message}</h3>";
            }
        }

        protected void BtnUpd_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)Session["DoctTable"];
            try
            {
                if (dt == null)
                {
                    lbloutputs.Text = "<h2>Doctor Data not found</h2>";
                    return;

                }
                DataRow doc_dr = dt.Rows.Find(int.Parse(TextBoxID.Text));

                if (doc_dr != null)
                {
                    //doc_dr[0] = int.Parse(TextBoxID.Text);
                    doc_dr[1] = TextBoxDName.Text;
                    doc_dr[2] = TextBoxDDOB.Text;
                    doc_dr[3] = TextBoxSS.Text;
                    doc_dr[4] = DropDownSpecial.Text.ToString();
                    doc_dr[5] = TextBoxContNo.Text;
                    doc_dr[6] = TextBoxDept.Text;
                    doc_dr[7] = DropDownDGender.Text.ToString();
                    lbloutputs.Text = "<h3>ROW Updated Successfully</h3>";
                }
                else
                {
                    lbloutputs.Text = $"<h3>Sorry!!! Doctor Data not found</h3>";
                }
            }
            catch (SqlException err)
            {
                lbloutputs.Text = $"<h3>ERROR!!!!{err.Message}</h3>";
            }
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)Session["DoctTable"];
            int rowsChanged = SQLHelp.SaveDoctorChanges(dt);
            lbloutputs.Text = $"<h3>Rows Modified{rowsChanged}</h3>";
        }

        protected void BtnDel_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)Session["DoctTable"];
            try
            {
                if (dt == null)
                {
                    lbloutputs.Text = "<h2>Doctor Data not found</h3>";
                    return;

                }
                DataRow emp_dr = null;

                if (TextBoxID.Text != "")

                    emp_dr = dt.Rows.Find(int.Parse(TextBoxID.Text));
                if (emp_dr != null)
                {
                    
                    dt.Rows.Remove(emp_dr);
                    lbloutputs.Text += "<h3>Row deleted </h3>" + $"<p>Count:{dt.Rows.Count}</p>";

                }
                else
                {

                    lbloutputs.Text = "<h3>ERROR !!!!Doctor Data Not Found</h3>";
                }
            }
            catch (SqlException err)
            {
                lbloutputs.Text = $"<h3>ERROR!!!!{err.Message}</h3>";
            }
        }

        protected void BtnClear_Click(object sender, EventArgs e)
        {
            TextBoxID.Text = string.Empty;
            TextBoxDName.Text = string.Empty;
            TextBoxDDOB.Text = string.Empty;
            TextBoxContNo.Text = string.Empty;
            TextBoxDept.Text = string.Empty;
            TextBoxSS.Text = string.Empty;
            

        }
    }
}