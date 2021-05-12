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
    public partial class PatientDoctor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable viewlist = SQLHelp.ViewList();
                Session["Viewlist"] = viewlist;
            }


            if (Session["DoctTable"] == null)
                {   
                    DataTable dpt = SQLHelp.GetDocPatData();
                    DataSet ds = new DataSet();
                    ds.Tables.Add(dpt);
                    Session["TableDB_Dataset"] = ds;
                    Session["DoctPatTable"] = dpt;
                }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataTable pdt = (DataTable)Session["PDTable"];

            try
            {
                if (pdt == null)
                {
                    output.Text = "<h2>Record not found</h3>";
                    return;

                }
                DataRow pd_dr = null;

                if (TextBoxid.Text != "")

                    pd_dr = pdt.Rows.Find(int.Parse(TextBoxid.Text));
                if (pd_dr != null)
                {
                    output.Text = "<h3>ERROR!!!!Duplicate Record</h3>";
                    return;
                }
                else
                {
                    pd_dr = pdt.NewRow();
                    pd_dr[0] = int.Parse(TextBoxid.Text);
                    pd_dr[1] = TextBoxpid.Text;
                    pd_dr[2] = TextBoxPtype.Text;
                    pd_dr[3] = TextBoxRef.Text;
                    pd_dr[4] = TextBoxHealth.Text;
                    pdt.Rows.Add(pd_dr);
                    output.Text += "<h3>Row Inserted </h3>" + $"<p>Count:{pdt.Rows.Count}</p>";


                }
            }
            catch (SqlException err)
            {
                output.Text = $"<h3>ERROR!!!!{err.Message}</h3>";
            }
        }

        protected void BtnVList_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewList.aspx");
        }
    }
}