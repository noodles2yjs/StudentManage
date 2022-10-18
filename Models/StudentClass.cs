using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// StudentClass 实体类
    /// </summary>
    [Serializable]
    public  class StudentClass
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }
    }
}
