//// ----------------------------------------------------------------------------
//// Título:    SQLiteDatabase_class
////
//// Fecha:     01/07/2016
//// Autor:    Alex Solé
//// ----------------------------------------------------------------------------

//using System;
//using System.Linq;
//using System.Data;
//using System.Collections.Generic;
//using System.Configuration;
//using System.Data.SQLite;

//namespace Clibb.Architecture.Infrastructure.SQLite
//{
//    public static class SQLiteDatabase
//    {
//        static readonly SQLiteConnection dbConnection = new SQLiteConnection(ConfigurationManager.AppSettings[SQLITE_CONFIG]);
//        const string SQLITE_CONFIG = "SQLiteDb";

//        private static DataTable GetDataTable(string sql)
//        {
//            DataTable dt = new DataTable();
//            try
//            {
//                SQLiteConnection cnn = new SQLiteConnection(dbConnection);
//                cnn.Open();
//                SQLiteCommand mycommand = new SQLiteCommand(cnn);
//                mycommand.CommandText = sql;
//                SQLiteDataReader reader = mycommand.ExecuteReader();
//                dt.Load(reader);
//                reader.Close();
//                cnn.Close();
//            }
//            catch (Exception e)
//            {
//                throw new Exception(e.Message);
//            }
//            return dt;
//        }

//        private static int ExecuteNonQuery(string sql)
//        {
//            dbConnection.Open();
//            SQLiteCommand mycommand = new SQLiteCommand(dbConnection);
//            mycommand.CommandText = sql;
//            int rowsUpdated = mycommand.ExecuteNonQuery();
//            dbConnection.Close();
//            return rowsUpdated;
//        }

//        private static string ExecuteScalar(string sql)
//        {
//            SQLiteConnection cnn = new SQLiteConnection(dbConnection);
//            cnn.Open();
//            SQLiteCommand mycommand = new SQLiteCommand(cnn);
//            mycommand.CommandText = sql;
//            object value = mycommand.ExecuteScalar();
//            cnn.Close();
//            if (value != null)
//            {
//                return value.ToString();
//            }
//            return "";
//        }

//        public static bool Update(String tableName, Dictionary<String, String> data, String where)
//        {
//            String vals = "";
//            Boolean returnCode = true;
//            if (data.Count >= 1)
//            {
//                foreach (KeyValuePair<String, String> val in data)
//                {
//                    vals += String.Format(" {0} = '{1}',", val.Key.ToString(), val.Value.ToString());
//                }
//                vals = vals.Substring(0, vals.Length - 1);
//            }
//            try
//            {
//                ExecuteNonQuery(String.Format("update {0} set {1} where {2};", tableName, vals, where));
//            }
//            catch
//            {
//                returnCode = false;
//            }
//            return returnCode;
//        }

//        public static bool Delete(String tableName, String where)
//        {
//            Boolean returnCode = true;
//            try
//            {
//                ExecuteNonQuery(String.Format("delete from {0} where {1};", tableName, where));
//            }
//            catch (Exception fail)
//            {
//                returnCode = false;
//            }
//            return returnCode;
//        }

//        public static bool Insert(String tableName, Dictionary<String, String> data)
//        {
//            String columns = "";
//            String values = "";
//            Boolean returnCode = true;
//            foreach (KeyValuePair<String, String> val in data)
//            {
//                columns += String.Format(" {0},", val.Key.ToString());
//                values += String.Format(" '{0}',", val.Value);
//            }
//            columns = columns.Substring(0, columns.Length - 1);
//            values = values.Substring(0, values.Length - 1);
//            try
//            {
//                ExecuteNonQuery(String.Format("insert into {0}({1}) values({2});", tableName, columns, values));
//            }
//            catch (Exception fail)
//            {
//                returnCode = false;
//            }
//            return returnCode;
//        }

//        //public static bool ClearDB()
//        //{
//        //    DataTable tables;
//        //    try
//        //    {
//        //        tables = GetDataTable("select NAME from SQLITE_MASTER where type='table' order by NAME;");
//        //        foreach (DataRow table in tables.Rows)
//        //        {
//        //            ClearTable(table["NAME"].ToString());
//        //        }
//        //        return true;
//        //    }
//        //    catch
//        //    {
//        //        return false;
//        //    }
//        //}


//    }


//}
