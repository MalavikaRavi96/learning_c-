using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Adodotnet
{
    public partial class AppointmentForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable applist = Hosp.AppList();
                Session["Applist"] = applist;
            }
            if (!IsPostBack)
            {
                DropDownList1.Items.Add("GYNACOLOGIST");
                DropDownList1.Items.Add("OPHTHALMOLOGIST");
                DropDownList1.Items.Add("CARDIOLOGIST");
                DropDownList1.Items.Add("EMERGENCY");
            }
        }

        protected void btnlist_Click(object sender, EventArgs e)
        {
            Response.Redirect("Appgrid.aspx");          

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)Session["Applist"];
            try
            {
                if (dt == null)
                {
                    lbloutput.Text = "<h2>Appointment not found</h2>";
                    return;
                }
                DataRow hosp_dr = null;
                if (txtdocID.Text != "")
                    hosp_dr = dt.Rows.Find(int.Parse(txtdocID.Text));

                if (hosp_dr != null)
                {
                    lbloutput.Text = "<h3>ERROR!!! Duplicate Appointment </h3>";
                    return;
                }
                else
                {
                    hosp_dr = dt.NewRow();
                    hosp_dr[0] = int.Parse(txtNo.Text);
                    hosp_dr[1] = int.Parse(txtdocID.Text);
                    hosp_dr[2] = int.Parse(txtpno.Text);
                    hosp_dr[3] = txtdoa.Text;
                    hosp_dr[4] = int.Parse(txtcf.Text);
                    hosp_dr[5] = DropDownList1.Text;

                    lbloutput.Text = $"<p>Count before Add: {dt.Rows.Count}</p>" +
                         $"<p>Count: { dt.Rows.Count} </p>";
                    dt.Rows.Add(hosp_dr);
                    lbloutput.Text = "<h3>New Patient added Successfully</h3>" +
                         $"<p>Count: { dt.Rows.Count} </p>";

                }
            }
            catch (SqlException err)
            {
                lbloutput.Text = $"<h3>ERROR!!!! {err.Message}</h3>";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)Session["DoctTable"];
            int rowsChanged = Hosp.SaveChanges(dt);
            lbloutput.Text = $"<h3>Rows Modified{rowsChanged}</h3>";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)Session["Applist"];
            try
            {
                if (dt == null)
                {
                    lbloutput.Text = "<h2>Appointment not found</h2>";
                    return;
                }
                DataRow hosp_dr = dt.Rows.Find(int.Parse(txtdocID.Text));
                if (hosp_dr != null)
                {
                    lbloutput.Text = "<h3>ERROR!!! Duplicate Appointment </h3>";
                    return;
                }
                else
                {
                    hosp_dr = dt.NewRow();
                    hosp_dr[0] = int.Parse(txtNo.Text);
                    hosp_dr[1] = int.Parse(txtdocID.Text);
                    hosp_dr[2] = int.Parse(txtpno.Text);
                    hosp_dr[3] = txtdoa.Text;
                    hosp_dr[4] = int.Parse(txtcf.Text);
                    hosp_dr[5] = DropDownList1.Text;

                    lbloutput.Text = $"<p>Count before Add: {dt.Rows.Count}</p>" +
                         $"<p>Count: { dt.Rows.Count} </p>";
                    //dt.Rows.Add(hosp_dr);
                    lbloutput.Text = "<h3>New Patient added Successfully</h3>" +
                         $"<p>Count: { dt.Rows.Count} </p>";
                }
            }
            catch (SqlException err)
            {
                lbloutput.Text = $"<h3>ERROR!!!!{err.Message}</h3>";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = null;
            try
            {
                DataTable dt = (DataTable)Session["Applist"];
                if (dt == null)
                {
                    lbloutput.Text = "Appointment not found";
                    return;
                }
                DataRow hosp_dr = dt.Rows.Find(int.Parse(txtdocID.Text));
                if (hosp_dr != null)
                {
                    txtNo.Text = hosp_dr[0].ToString();
                    txtdocID.Text = hosp_dr[1].ToString();
                    txtpno.Text = hosp_dr[2].ToString();
                    txtdoa.Text = hosp_dr[3].ToString();
                    txtcf.Text = hosp_dr[4].ToString();
                    DropDownList1.Text = hosp_dr[5].ToString();

                }
                else
                {
                    lbloutput.Text = $"<h3>ERROR!!!Appointment not found</h3>";
                }
            }
            catch (SqlException err)
            {
                lbloutput.Text = $"<h3>ERROR!!!!{err.Message}</h3>";
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String Special = DropDownList1.SelectedValue;
            Response.Write("<p>" + Special + "</p>");
        }
    }
}