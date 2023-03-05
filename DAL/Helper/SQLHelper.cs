
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTY.DAL
{
    /// <summary>
    /// 通用数据访问类
    /// </summary>
    internal class SQLHelper 
    {
        // 读取字符串
          private static string connString  = ConfigurationManager.ConnectionStrings["ConnString"].ToString();

        // 使用加密字符串获取连接字符
        // private static string connString = StringSecurity.DESDecrypt(ConfigurationManager.ConnectionStrings["connString2"].ToString());
        /// <summary>
        /// 执行 insert,update,delete类型sql
        /// </summary>
        /// <param name="cmdText">sql语句或存储过程</param>
        /// <param name="sqlParameters">参数数组</param>
        /// <returns>受影响的行数</returns>
        public static int  ExecuteNonQuery(string cmdText, SqlParameter[] sqlParameters = null)
        {
            SqlConnection conn= new SqlConnection(connString);
            SqlCommand cmd= new SqlCommand(cmdText,conn);

            if (sqlParameters != null)
            {
                cmd.Parameters.AddRange(sqlParameters);
            }

            try
            {
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // 可以在这个地方写入日志文件
                string errMsg = $"{DateTime.Now}: 执行 public static int  ExcuteNonQuery(string cmdText, SqlParameter[] sqlParameters = null) 发生异常: {ex.Message}";
                throw new Exception(errMsg);
            }
            finally { conn.Close(); }
        }

      public  static bool ExecuteNonQueryByTrans(string sql,List<SqlParameter[]> paramArrayList )
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection= conn;
            try
            {
                conn.Open();
                cmd.Transaction = conn.BeginTransaction();// 开启事务
                cmd.CommandText= sql;
                foreach (SqlParameter[] param in paramArrayList)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddRange(param);
                    cmd.ExecuteNonQuery();
                }
                cmd.Transaction.Commit();// 提交事务,同时自动清除事务
                return true;
            }
            catch (Exception ex)
            {
                if (cmd.Transaction !=null)
                {
                    cmd.Transaction.Rollback();// 回滚事务,同时自动清除事务
                }
                throw new Exception("ExecuteNonQueryByTrans(string sql,List<SqlParameter[]> paramArrayList )时出现错误"+ex.Message);
            }
            finally 
            {
                if (cmd.Transaction != null)
                {
                    cmd.Transaction =null;
                }
                conn.Close();
            
            }
        }
        /// <summary>
        /// 执行单一结果查询
        /// </summary>
        /// <param name="cmdText"></param>
        /// <param name="sqlParameters"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static object ExecuteScalar(string cmdText, SqlParameter[] sqlParameters = null)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(cmdText, conn);

            if (sqlParameters != null)
            {
                cmd.Parameters.AddRange(sqlParameters);

            }
           

            try
            {
                conn.Open();
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                string errMsg = $"{DateTime.Now}: 执行 public static object ExecuteScalar(string cmdText, SqlParameter[] sqlParameters = null) 发生异常: {ex.Message}";
                throw new Exception(errMsg);
            }
            finally { conn.Close(); }
        }
        /// <summary>
        /// 执行返回一个在线结果集的查询
        /// </summary>
        /// <param name="cmdText"></param>
        /// <param name="sqlParameters"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string cmdText, SqlParameter[] sqlParameters = null)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            if (sqlParameters != null) { cmd.Parameters.AddRange(sqlParameters); }
            try
            {
                conn.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);

            }
            catch (Exception ex)
            {

                string errMsg = $"{DateTime.Now}: 执行 public static object ExecuteReader(string cmdText, SqlParameter[] sqlParameters = null) 发生异常: {ex.Message}";
                throw new Exception(errMsg);
            }
           
        }
        /// <summary>
        /// 返回含有一张数据表的数据集查询
        /// </summary>
        /// <param name="cmdText"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static DataSet GetDataSet(string cmdText, string tableName = null)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            SqlDataAdapter dataAdapter= new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
          
            try
            {
                conn.Open();

                if (tableName != null)
                {
                    dataAdapter.Fill(ds,tableName);
                }
                else
                {
                    dataAdapter.Fill(ds);
                }
                return ds;
            }
            catch (Exception ex)
            {

                string errMsg = $"{DateTime.Now}: 执行    public static DataSet GetDataSet(string cmdText, string tableName = null) 发生异常: {ex.Message}";
                throw new Exception(errMsg);
            }
            finally { conn.Close(); }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dicTableAndSql"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static DataSet GetDataSet(Dictionary<string,string> dicTableAndSql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            try
            {
                conn.Open();
                foreach (string tbName in dicTableAndSql.Keys)
                {
                    cmd.CommandText = dicTableAndSql[tbName];
                    dataAdapter.Fill(ds,tbName);
                }
                return ds;
            }
            catch (Exception ex)
            {

                string errMsg = $"{DateTime.Now}: 执行    public static DataSet GetDataSet(Dictionary<string,string> dicTableAndSql) 发生异常: {ex.Message}";
                throw new Exception(errMsg);
            }
            finally { conn.Close(); }   

          
        }
    }
}
