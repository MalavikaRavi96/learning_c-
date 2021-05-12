using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;

namespace TestProject
{
    public class SQLHelp
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
            SqlCommand dmlDPcmd = null;
            try
            {
                con = GetSqlConnection();
                if (con.State != System.Data.ConnectionState.Open) con.Open();
                dmlDPcmd = con.CreateCommand();
                dmlDPcmd.CommandText = query;
                result = dmlDPcmd.ExecuteNonQuery();

            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
            return result;

        }
        public static DataTable GetDocData()
        {
            DataTable doctable = null;
            SqlConnection con = null;
            SqlDataAdapter da = null;
            con = GetSqlConnection();
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = con;
            da.SelectCommand.CommandText = "Select * from DoctorMaster_gavs";
            doctable = new DataTable("DoctTable");
            da.Fill(doctable);
            doctable.PrimaryKey = new DataColumn[] { doctable.Columns[0] };
            return doctable;


        }
        public static DataTable GetDataPatient()
        {
            DataTable patientt = null;
            SqlConnection con = null;
            SqlDataAdapter da = null;


            con = GetSqlConnection();
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();

            da.SelectCommand.Connection = con;
            da.SelectCommand.CommandText = "Select * from PatientDetails_gavs";
            patientt = new DataTable("Pateint");
            da.Fill(patientt);
            patientt.PrimaryKey = new DataColumn[] { patientt.Columns[0] };

            return patientt;


        }
        public static DataRow GetDataRow(SqlCommand cmd)
        {
            DataRow docdr = null;
            DataTable docdt = null;
            SqlConnection con = null;
            SqlDataAdapter da = null;
            con = GetSqlConnection();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.SelectCommand.Connection = con;
            docdt = new DataTable("Emp");
            da.Fill(docdt);
            docdr = docdt.Rows[0];
            return docdr;

        }

        public static int SaveDoctorChanges(DataTable dt)
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
            
            da.SelectCommand.CommandText = "Select * from DoctorMaster_gavs";
            SqlCommandBuilder cmbuilder = new SqlCommandBuilder(da);
            result = da.Update(dt);
            trans.Commit();
            con.Close();
            return result;
        }

        public static DataTable GetDocPatData()
        {
            DataTable dptable = null;
            SqlConnection con = null;
            SqlDataAdapter da = null;
            con = GetSqlConnection();
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = con;
            da.SelectCommand.CommandText = "Select * from DoctorPatientDetails_gavs";
            dptable = new DataTable("DoctPatTable");
            da.Fill(dptable);
          //  dptable.PrimaryKey = new DataColumn[] { dptable.Columns[0] };
            return dptable;


        }


        public static int SaveDoctorPatientChanges(DataTable dt)
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

            da.SelectCommand.CommandText = "Select * from DoctorPatientDetails_gavs";
            SqlCommandBuilder cmbuilder = new SqlCommandBuilder(da);
            result = da.Update(dt);
            trans.Commit();
            con.Close();
            return result;
        }


        public static DataTable ViewList()
        {
            DataTable viewdt = null;
            SqlConnection con = null;
            SqlDataAdapter da = null;
            con = GetSqlConnection();
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = con;
            da.SelectCommand.CommandText = "Select * from DoctorPatientDetails_gavs";
            viewdt = new DataTable("Hosp");
            da.Fill(viewdt);
         //   viewdt.PrimaryKey = new DataColumn[] { viewdt.Columns[0] };
            return viewdt;
        }
    }
}