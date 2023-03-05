using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Models;
using GTY.DAL;

namespace DAL
{
    /// <summary>
    /// 数据库Admins表的服务类
    /// </summary>
   
    public class SysAdminService
    {
        /// <summary>
        /// 根据用户账号和密码登录
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        public SysAdmin AdminLogin(SysAdmin admin)
        {
            // 使用带参数的sql语句进行改进
            //string sql = $"select * from Admins where LoginId = {admin.LoginId} and LoginPwd = '{admin.LoginPwd}'";

            string sql2 = "select LoginId, LoginPwd, AdminName from Admins Where LoginId = @LoginId and LoginPwd=@LoginPwd";
            SqlParameter[] @params = new SqlParameter[]
            {
                new SqlParameter( "@LoginId",admin.LoginId),
                new SqlParameter( "@LoginPwd",admin.LoginPwd),
            };

            try
            {
                using (var reader = SQLHelper.ExecuteReader(sql2, @params))
                {
                    if (reader.Read())
                    {
                        admin.AdminName = reader["AdminName"].ToString();
                        reader.Close();
                       
                    }
                    else
                    {
                        admin = null;
                    }
                }

                 
                
            }
            catch (Exception)
            {

                throw ;
            }

            return admin;
        }

        /// <summary>
        /// 修改用户密码
        /// </summary>
        /// <param name="sysAdmin"></param>
        /// <returns></returns>
        public int ModifyPwd(SysAdmin sysAdmin)
        {
            //string sql = $"update admins set LoginPwd ={sysAdmin.LoginPwd} where LoginId = {sysAdmin.LoginId}";

            string sql2 = "update Admins set LoginPwd=@LoginPwd where LoginId = @LoginId";

            SqlParameter[] @params = new SqlParameter[]
         {
                new SqlParameter( "@LoginId",sysAdmin.LoginId),
                new SqlParameter( "@LoginPwd",sysAdmin.LoginPwd),
         };
            try
            {
                return SQLHelper.ExecuteNonQuery(sql2, @params);
            }
            catch (Exception)
            {

                throw ;
            }
        }

    }
}
