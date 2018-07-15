// ----------------------------------------------------------------------------
// Título:    Conection_class
// Implementa una conexión con una base de datos
//
// Fecha:     27/02/2011
// Autor:    Alex Solé
// ----------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
namespace Database
{
    public class DataSettings
    {
        private SqlConnection Conn;
        private SqlCommand Cmd { get; set; }
        private SqlDataReader Reader;
        private SqlDataAdapter dataAdapter;
        private DataSet Ds { get; set; }

        public DataSettings()
        {
            Conn = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["connString"]);
        }

        public SqlConnection OpenConn()
        {
            if (Conn.State == System.Data.ConnectionState.Closed || Conn.State == System.Data.ConnectionState.Broken)
            {
                Conn.Open();
            }
            return Conn;
        }

        public SqlConnection CloseConn()
        {
            if (Conn.State == System.Data.ConnectionState.Open)
            {
                Conn.Close();
            }

            return Conn;
        }


        public DataTable ReturnDataTable(string strQueryCommand)
        {
            Cmd = new SqlCommand();
            SqlDataAdapter adap;
            try
            {
                Cmd.Connection = OpenConn();
                Cmd.CommandText = strQueryCommand;
                adap = new SqlDataAdapter(Cmd);
                DataTable dt = new DataTable();
                adap.Fill(dt);

                return dt;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                Cmd = null;
            }
        }

        public DataSet ReturnDataSet(string strQueryCommand)
        {
            try
            {
                OpenConn();
                Cmd = Conn.CreateCommand();
                dataAdapter = new SqlDataAdapter(strQueryCommand, Conn);
                Ds = new DataSet();
                Ds.Reset();
                dataAdapter.Fill(Ds);

                return Ds;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Cmd = null;
                CloseConn();
            }
        }

        public void ExecuteQuery(string strQueryCommand)
        {
            try
            {
                Cmd.Connection = OpenConn();
                Cmd.CommandText = strQueryCommand;
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Cmd = null;
            }

        }
        /// <summary>
        /// call datareader
        /// </summary>
        /// <param name="strQueryCommand"></param>
        /// <returns></returns>
        public SqlDataReader ReturnDataReader(string strQueryCommand)
        {
            try
            {
                Cmd = Conn.CreateCommand();
                Cmd.CommandText = strQueryCommand;
                Reader = Cmd.ExecuteReader();
                return Reader;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Cmd = null;
            }
        }




    }
}
