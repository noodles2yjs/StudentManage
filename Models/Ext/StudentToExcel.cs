using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Ext
{
    public class StudentToExcel
    {
       // public int StudentId { get; set; } // 学号
        public string StudentName { get; set; }
        public string Gender { get; set; }
        public DateTime Birthday { get; set; }
        public int Age { get; set; } // 年龄
        public string CardNo { get; set; }// 考勤卡号
        public string StudentIdNo { get; set; }// 身份证号
             
        public string PhoneNumber { get; set; }
        public string StudentAddress { get; set; }
        public int ClassId { get; set; }

    }
}
