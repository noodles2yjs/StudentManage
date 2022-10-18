using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Models
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
            string sql = $"select * from Admins where LoginId = {admin.LoginId} and LoginPwd = '{admin.LoginPwd}'";

            try
            {
                using (SqlDataReader sqlDataReader = SQLServerHelper.GetReader(sql))
                {
                    if (sqlDataReader.Read())
                    {
                        admin.AdminName = sqlDataReader["AdminName"].ToString();
                        sqlDataReader.Close();
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

    }
}
