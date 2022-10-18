using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 数据库Admins表的实体类
    /// </summary>
    [Serializable]
    public class SysAdmin
    {

        public int LoginId { get; set; }
        public string LoginPwd { get; set; }
        public string AdminName { get; set; }


    }
}
