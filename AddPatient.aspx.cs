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
    public partial class AddPatient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                genderdrop.Items.Add("F");
                genderdrop.Items.Add("M");
                genderdrop.Items.Add("T");
               
                if (Session["PatientTable"] == null)
                {
                    DataTable dt = SHelper.GetDataPatient();
                    DataSet ds = new DataSet();
                    ds.Tables.Add(dt);
                    Session["TestDB_Dataset"] = ds;
                    Session["PatientTable"] = dt;
                }




            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            DataTable dt = (DataTable)Session["PatientTable"];
            try
            {
                if (dt == null)
                {
                    lbloutput.Text = "<h2> Patient table not found </h3>";
                    return;
                }
                DataRow patient_dr = null;
                if (id_text.Text != "")
                {
                    patient_dr = dt.Rows.Find(int.Parse(id_text.Text));
                }


                if (patient_dr != null)
                {
                    lbloutput.Text = "<h3> Error !! duplicate IdentityNumber</h3>";
                    return;
                }
                else
                {
                    patient_dr = dt.NewRow();
                    patient_dr[0] = int.Parse(id_text.Text);
                    patient_dr[1] = pName_text.Text;
                    patient_dr[2] = DateTime.Parse(dob_text.Text);
                    patient_dr[3] = Contact_text.Text;
                    patient_dr[5] = Ph_text.Text;
                    patient_dr[4] = Address_text.Text;
                    patient_dr[6] = genderdrop.Text.ToString();
                    lbloutput.Text += $"<h3>  count before add {dt.Rows.Count}";
                    dt.Rows.Add(patient_dr);
                    lbloutput.Text += $"<h3>  count after add {dt.Rows.Count}";
                    lbloutput.Text += "<h3> new row added </h3>";
                }
            }



            
            catch (SqlException err)
            {
                Response.Write($"<h1>ERROR!!! {err.Message} </h1>");
            }
        }

        protected void dob_text_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Contact_text_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Ph_text_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)Session["PatientTable"];
            try
            {
               
                if (dt == null)
                {
                    lbloutput.Text = "Patient Table not Found";
                    return;
                }



                DataRow p_Dr = dt.Rows.Find(int.Parse(id_text.Text));
                
                if (p_Dr != null)
                {
                    p_Dr["PersonNo"] = id_text.Text;
                    p_Dr["PersonName"] = pName_text.Text;
                    p_Dr["DateofBirth"] = DateTime.Parse(dob_text.Text);
                    p_Dr["ContactPerson"] = Contact_text.Text;
                    p_Dr["Phone"] = Ph_text.Text;
                    p_Dr["Address"] = Address_text.Text;
                    p_Dr["Gender"] = genderdrop.Text.ToString();

                    lbloutputp.Text = "<h3>Updated Row</h3>";
                }
                else
                {

                    lbloutputp.Text = $"<h3>error Patient not Found !!</h3>";
                }
            }
            catch (Exception err)
            {
                lbloutputp.Text = $"<h3>error !!{err.Message}</h3>";
            }
        }

        protected void btn_remove_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)Session["PatientTable"];
            try
            {
               

                DataRow emp_dr = null;

                if (id_text.Text != "")

                    emp_dr = dt.Rows.Find(int.Parse(id_text.Text));

                if (emp_dr != null)
                {
                    lbloutput.Text += $"<p>count before:{dt.Rows.Count}";
                    dt.Rows.Remove(emp_dr);
                    lbloutput.Text += $"<p>count before:{dt.Rows.Count}";
                    return;
                }
                else
                {
                    lbloutput.Text += "<h3> error!! employeeid not found</h3>";
                    return;
                }
            }
            catch (SqlException err)
            {
                lbloutput.Text = $"<h3>error !!{err.Message}</h3>";
            }
        }

        protected void Btn_save_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)Session["PatientTable"];
            int rowschanged = SHelper.SavePatientChanges(dt);
            lbloutput.Text = $"<h3> rows   modified {rowschanged} </h3>";

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)Session["PatientTable"];
            try
            {
                
                if (dt == null)
                {
                    lbloutput.Text = "Patient Table not Found";
                    return;
                }



                DataRow p_Dr = dt.Rows.Find(int.Parse(id_text.Text));
                if (p_Dr != null)
                {
                    id_text.Text = p_Dr[0].ToString();
                    pName_text.Text = p_Dr[1].ToString();
                    dob_text.Text = p_Dr[2].ToString();
                    Contact_text.Text = p_Dr[3].ToString();
                    Ph_text.Text = p_Dr[4].ToString();
                    Address_text.Text = p_Dr[5].ToString();
                    genderdrop.Text = p_Dr[6].ToString();
                }
                else
                {

                    lbloutput.Text = $"<h3>error Patient not Found !!</h3>";
                }
            }
            catch (SqlException err)
            {
                lbloutput.Text = $"<h3>error !!{err.Message}</h3>";
            }
        }
    }
}
