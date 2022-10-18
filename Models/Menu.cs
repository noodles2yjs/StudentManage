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
        public string MenuName { get; set; }
        public string MenuCode { get; set; }
        public int ParentId { get; set; }

    }
}
