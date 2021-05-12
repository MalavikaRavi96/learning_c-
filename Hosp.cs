using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Adodotnet
{
    public class Hosp
    {
        public static SqlConnection GetSqlConnection()
        {
            SqlConnection cnTestDB = null;
            string strConnect;
            strConnect = "server=10.0.7.21;database=TestDB;uid=gavsbcpltp;pwd=G@v$ltp456";
            cnTestDB = new SqlConnection(strConnect);
            return cnTestDB;
        }
        public static DataTable Docdetails()
        {
            DataTable hospdt = null;
            SqlConnection con = null;
            SqlDataAdapter da = null;
            con = GetSqlConnection();
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = con;
            da.SelectCommand.CommandText = "Select * from DoctorMaster_gavs";
            hospdt = new DataTable("Hosp");
            da.Fill(hospdt);
            hospdt.PrimaryKey = new DataColumn[] { hospdt.Columns[0] };
            return hospdt;
        }
        public static DataTable AppList()
        {
            DataTable hospdt = null;
            SqlConnection con = null;
            SqlDataAdapter da = null;
            con = GetSqlConnection();
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = con;
            da.SelectCommand.CommandText = "Select * from AppointmentDetails_gavs";
            hospdt = new DataTable("Hosp");
            da.Fill(hospdt);
            hospdt.PrimaryKey = new DataColumn[] { hospdt.Columns[0] };
            return hospdt;
        }
        public static int SaveChanges(DataTable dt)
        {
            int result = 0;
            SqlConnection con = null;
            SqlDataAdapter da = null;
            con = GetSqlConnection();
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = con;
            con.Open();
            SqlTransaction trans = con.BeginTransaction();
            da.SelectCommand.Transaction = trans;

            da.SelectCommand.CommandText = "Select  * from AppointmentDetails_gavs";
            SqlCommandBuilder cmbuilder = new SqlCommandBuilder(da);
            result = da.Update(dt);
            trans.Commit();
            con.Close();
            return result;
        }

    }
}