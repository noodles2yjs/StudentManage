using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    ///  Attendance 实体类
    /// </summary>
    [Serializable]
    public class Attendance
    {
        public int Id { get; set; }
        public string CarNo { get; set; }
        public DateTime? Dtime { get; set; }


    }
}
