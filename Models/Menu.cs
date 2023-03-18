using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// MenuList 实体类
    /// </summary|>
    [Serializable]
    public class Menu
    {
        public int MenuId { get; set; }
        public string MenuName { get; set; } //菜单名称
        public string MenuCode { get; set; } //例如: ModifyPwd (用来存放窗体名称,需要结合反射使用)
        public int ParentId { get; set; }// 父节点ID,

    }
}
