using GTY.DAL;
using Models;
using Models.Ext;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Helper
{
    /// <summary>
    ///
    /// </summary>
    public class ImportDataFromExcel
    {
        /// <summary>
        ///  从Excel中读取数据 // 需要依赖com组件,此类启用,使用第三方NPOI
        /// </summary>
        /// <returns></returns>
    /*    public static List<Student> GetStudentByExcel(string path)
        {
            List<Student> list = new List<Student>();
            DataSet ds = SQLHelper.GetDataSet("select * from [Student$] ", path);
            DataTable dt = ds.Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Student()
                {
                    StudentName = row["姓名"].ToString(),
                    Gender = row["性别"].ToString(),
                    Birthday = Convert.ToDateTime(row["出生日期"]),
                    Age = DateTime.Now.Year - Convert.ToDateTime(row["出生日期"]).Year,
                    CardNo = row["考勤卡号"].ToString(),
                    StudentIdNo = row["身份证号"].ToString(),
                    PhoneNumber = row["电话号码"].ToString(),
                    StudentAddress = row["家庭住址"].ToString(),
                    ClassId = Convert.ToInt32(row["班级编号"])
                });
            }
            return list;
        }*/
        /// <summary>
        /// 将集合中的对象插入到数据库
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static bool Import(List<StudentToExcel> list)
        {
            List<string> sqlList = new List<string>();
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("insert into Students(studentName,Gender,Birthday,");
            sqlBuilder.Append("StudentIdNo,Age,PhoneNumber,StudentAddress,CardNo,ClassId)");
            sqlBuilder.Append(" values('{0}','{1}','{2}',{3},{4},'{5}','{6}','{7}',{8})");
            foreach (StudentToExcel objStudent in list)
            {
                string sql = string.Format(sqlBuilder.ToString(), objStudent.StudentName,
                     objStudent.Gender, objStudent.Birthday,
                    objStudent.StudentIdNo, objStudent.Age,
                    objStudent.PhoneNumber, objStudent.StudentAddress, objStudent.CardNo,
                    objStudent.ClassId);
                sqlList.Add(sql);
            }
            return SQLHelper.UpdateByTran(sqlList);
        }
    }
}
