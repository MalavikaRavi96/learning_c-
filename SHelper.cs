using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;

namespace HospitalTask
{
    public class SHelper
    {
        public static SqlConnection GetSqlConnection()
        {
            SqlConnection cnTestDb = null;
            String slconnect;
            slconnect = ConfigurationManager.ConnectionStrings["andal"].ConnectionString;
            cnTestDb = new SqlConnection(slconnect);
            
            
            // slconnect = "server = 10.0.7.21; database = TestDB; uid = gavsbcpltp; pwd = G@v$ltp456";
            cnTestDb = new SqlConnection(slconnect);

            return cnTestDb;
        }
        public static int ExecuteDMLQuery(SqlCommand querycmd)
        {
            int result = 0;
            SqlConnection con = null;
            SqlTransaction trans = null;

            try
            {
                con = GetSqlConnection();
                if (con.State != System.Data.ConnectionState.Open) con.Open();
                trans = con.BeginTransaction();

                querycmd.Connection = con;
                querycmd.Transaction = trans;
                result = querycmd.ExecuteNonQuery();
                trans.Rollback();

            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
            return result;
        }
        public static int ExecuteDMLQuery1(String query)
        {
            int result = 0;
            SqlConnection con = null;
            SqlCommand dmlEmpcmd = null;
            try
            {
                con = GetSqlConnection();
                if (con.State != System.Data.ConnectionState.Open) con.Open();
                dmlEmpcmd = con.CreateCommand();
                dmlEmpcmd.CommandText = query;
                result = dmlEmpcmd.ExecuteNonQuery();

            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
            return result;

        }
     
        public static DataTable GetDataPatient()
        {
            DataTable empt = null;
            SqlConnection con = null;
            SqlDataAdapter da = null;


            con = GetSqlConnection();
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();

            da.SelectCommand.Connection = con;
            da.SelectCommand.CommandText = "Select  * from PatientMaster_gavs";
            empt = new DataTable("Pateint");
            da.Fill(empt);
            empt.PrimaryKey = new DataColumn[] { empt.Columns[0] };

            return empt;


        }
        public static DataRow GetDataRow(SqlCommand cmd)
        {
            DataRow empdr = null;
            DataTable empdt = null;
            SqlConnection con = null;
            SqlDataAdapter da = null;
            con = GetSqlConnection();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.SelectCommand.Connection = con;
            empdt = new DataTable("Emp");
            da.Fill(empdt);
            empdr = empdt.Rows[0];
            return empdr;

        }

        public static int SavePatientChanges(DataTable dt)
        {
            int result = 0;
            SqlConnection con = null;
            SqlDataAdapter da = null;
            try
            {
                con = GetSqlConnection();
                da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.Connection = con;
                con.Open();
                SqlTransaction trans = con.BeginTransaction();
                da.SelectCommand.Transaction = trans;


                da.SelectCommand.CommandText = "Select  * from PatientMaster_gavs";
                SqlCommandBuilder cmbuilder = new SqlCommandBuilder(da);
                result = da.Update(dt);
                trans.Commit();
            }
            finally
            {

                con.Close();
            }

            return result;
        }
    }
}