using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace TestProject
{
    public partial class ViewList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable viewlist = (DataTable)Session["Viewlist"];

            if (viewlist == null)
            {
                Response.Write("<h2> List is NULL!!!</h2>");
            }

            else
            {
                GridView1.DataSource = viewlist;
                GridView1.DataBind();
                Response.Write("<h2>Done</h2>");
            }
        }
    }
}