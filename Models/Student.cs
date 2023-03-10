using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// Students 实体类
    /// </summary>
    [Serializable]
  public  class Student
    {
        public int StudentId { get; set; } // 学号
        public string StudentName { get; set; }
        public string Gender { get; set; }
        public DateTime Birthday { get; set; }
        public string StudentIdNo { get; set; }// 身份证号
        public string CardNo { get; set; }// 考勤卡号

        public string StuImage { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string StudentAddress { get; set; }
        public int  ClassId { get; set; }

        // 扩展属性
        public string ClassName { get; set; }
        public string CSharp { get; set; }
        public string SQLServerDB { get; set; }
        public DateTime DTime { get; set; }//签到时间

       

    }
}
