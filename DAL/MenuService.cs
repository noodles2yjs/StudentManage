using GTY.DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// MenuList 服务类
    /// </summary>

    public class MenuService
    {
        public  List<Menu> GetAllMeus()
        {
            List<Menu> menuList = new List<Menu>();
            string sql = "select MenuId, MenuName, MenuCode, ParentId from MenuList";

            var reader = SQLHelper.ExecuteReader(sql);
            while (reader.Read())
            {
                menuList.Add(
                    new Menu
                    {
                       MenuId =Convert.ToInt32(reader["MenuId"]),
                       MenuName = reader["MenuName"].ToString(),
                       MenuCode = reader["MenuCode"].ToString(),
                        ParentId = Convert.ToInt32(reader["ParentId"]),

                    }
                    );
            }

            reader.Close();
            return menuList;
        }
    }
}
