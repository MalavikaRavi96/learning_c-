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
    public partial class DoctorMaster : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnNewDoc_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddDoctor.aspx");
        }
        //To search doctor details:
        protected void BtnSearch_Click(object sender, EventArgs e)
        {
            
        }

        protected void BtnList_Click(object sender, EventArgs e)
        {
            
        }

        protected void BtnList_Click1(object sender, EventArgs e)
        {
            try
            {
                DataTable doc_dt = SQLHelp.GetDocData();

                //Data Set
                DataSet ds = new DataSet();
                ds.Tables.Add(doc_dt);
                Session["TestDB_Dataset"] = ds;

                //For GridViews
                Session["DoctTable"] = doc_dt;
                doctorview.DataSource = doc_dt;
                doctorview.DataBind();

                
            }
            catch (SqlException err)
            {
                lbloutput.Text = $"<h3>ERROR!!!!{err.Message}</h3>";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddDoctor.aspx");
        }
    }
}