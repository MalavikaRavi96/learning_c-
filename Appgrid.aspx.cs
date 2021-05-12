using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Adodotnet
{
    public partial class Appgrid : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable applist = (DataTable) Session["Applist"];

            if (applist == null)
            {
                Response.Write("<h2>Appointment List is NULL!!!</h2>");
            }
           
            else
            {
                GridView2.DataSource = applist;
                GridView2.DataBind();
                Response.Write("<h2>Done</h2>");
            }
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}