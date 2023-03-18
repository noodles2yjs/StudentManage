using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Ext
{
    public class StudentDgvToExcel // 把dgv数据导入到excel中
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Gender { get; set; }
        public string StudentIdNo { get; set; }
        public DateTime Birthday { get; set; }
        public string PhoneNumber { get; set; }
        public string ClassName { get; set; }

    }
}
