using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// Access 数据库访问类
    /// </summary>
  public  class OLEDBHelper
    {
        //适合Excel2003版本
        // private static string connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=Excel 8.0";
        //适合Excel2007以后的版本
        private static string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=Excel 8.0";

        /// <summary>
        /// 执行增、删、改（insert/update/delete）
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int Update(string sql)
        {
            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            try
            {
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// 执行单一结果查询（select）
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static object GetSingleResult(string sql)
        {
            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            try
            {
                conn.Open();
                object result = cmd.ExecuteScalar();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// 执行多结果查询（select）
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static OleDbDataReader GetReader(string sql)
        {
            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            try
            {
                conn.Open();
                OleDbDataReader objReader =
                    cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return objReader;
            }
            catch (Exception ex)
            {
                conn.Close();
                throw ex;
            }
        }
        /// <summary>
        /// 执行返回数据集的查询
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataSet GetDataSet(string sql)
        {
            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd); //创建数据适配器对象
            DataSet ds = new DataSet();//创建一个内存数据集
            try
            {
                conn.Open();
                da.Fill(ds);  //使用数据适配器填充数据集
                return ds;  //返回数据集
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// 读取数据到DataSet中
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        public static DataSet GetDataSet(string sql, string path)
        {
            OleDbConnection conn = new OleDbConnection(string.Format(connString, path));
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd); //创建数据适配器对象
            DataSet ds = new DataSet();//创建一个内存数据集
            try
            {
                conn.Open();
                da.Fill(ds);  //使用数据适配器填充数据集
                return ds;  //返回数据集
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
