using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// 通用sqlserver 连接类库
    /// </summary>
 public   class SQLServerHelper
    {

        public static string ConnString = ConfigurationManager.ConnectionStrings["ConnString"].ToString();

        /// <summary>
        /// 数据更新
        /// </summary>
        /// <returns></returns>
        public static  int Update(string sql)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(sql,sqlConnection))
                {
                    try
                    {
                        sqlConnection.Open();
                        return sqlCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }
                }
            }
           

        }

        /// <summary>
        /// 执行单一结果查询
        /// </summary>
        public static object GetSingleResult(string sql)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection))
                {
                    try
                    {
                        sqlConnection.Open();
                        return sqlCommand.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }
                }
            }


        }

        /// <summary>
        ///  执行一个结果集的查询
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static object GetReader(string sql)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection))
                {
                    try
                    {
                        sqlConnection.Open(); 
                        return sqlCommand.ExecuteReader();
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }
                }
            }


        }


        /// <summary>
        ///  执行一个结果集的查询 winform
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataSet GetDataSet(string sql)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection))
                {

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    DataSet dataSet = new DataSet();

                    try
                    {
                        sqlDataAdapter.Fill(dataSet);
                        return dataSet;
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }
                }
            }


        }
    }
}
