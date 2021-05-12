using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestProject
{
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }


        protected void BtnAppoint_Click(object sender, EventArgs e)
        {
            Response.Redirect("AppointmentForm (1).aspx");
        }

        

        protected void BtnPatDetails_Click(object sender, EventArgs e)
        {

        }

        protected void BtnDocDetail_Click(object sender, EventArgs e)
        {
            Response.Redirect("DoctorMaster.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("PatientPage.aspx");
        }

        protected void BtnDocpatient_Click(object sender, EventArgs e)
        {
            Response.Redirect("PatientDoctor.aspx");

        }
    }
}