using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Web.Security;
using System.Security.Principal;

namespace TestProject
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BTNAdminLogin_Click(object sender, EventArgs e)
        {
            string uname = TextBox1.Text;
            string pwd = TextBox2.Text;


            if (uname == "gavstech" && pwd == "Gavs@123")
            {
                FormsAuthentication.RedirectFromLoginPage(uname, true);

            }
        }
    }
}