using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalTask
{
    public partial class PatientPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           /// DataTable dt = (DataTable)Session["PatientTable"];

            try
            {
                DataTable patient_dr = SHelper.GetDataPatient();
                DataSet ds = new DataSet();
                ds.Tables.Add(patient_dr);
                Session["TestDB_Dataset"] = ds;
                Session["PatientTable"] = patient_dr;


                GridView1.DataSource = patient_dr;
                GridView1.DataBind();


            }
            catch (SqlException err)
            {
                lbloutputp.Text = $"<h3>error !!{err.Message}</h3>";
            }
        }

        protected void btn_getpatient_Click(object sender, EventArgs e)
        {
            
        }

        protected void btn_addpatient_Click(object sender, EventArgs e)
        {



            Response.Redirect("AddPatient.aspx");
        }

        protected void btn_save_Click(object sender, EventArgs e)
        {
            DataTable dt = null;
            Session["PatientTable"] = dt;
            int rowschanged = SHelper.SavePatientChanges(dt);
            lbloutputp.Text = $"<h3> rows   modified {rowschanged} </h3>";

        }
    }
}