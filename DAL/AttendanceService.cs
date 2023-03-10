using GTY.DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL

{
    /// <summary>
    ///  Attendance 服务类
    /// </summary>

    public class AttendanceService
    {
        // 添加打卡记录
        public string AddRecord(string cardNo)
        {
            string sql = " insert into Attendance (CardNo) values(@cardNo)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@cardNo",cardNo)
            };

            try
            {
                SQLHelper.ExecuteNonQuery(sql,sqlParameters);
                return "success";
            }
            catch (Exception ex)
            {

                return "打卡失败,系统出现问题,请联系管理员: " + ex.Message;
            }
        }

        // 获取所有人数
        public string GetAllStudentCount()
        {
            string sql = " select count(*) from Students;";

            try
            {
               return SQLHelper.ExecuteScalar(sql).ToString();
            }
            catch (Exception ex)
            {

                throw new Exception("获取所有学员人数失败: "+ex.Message);
            }
        }


        // 获取出勤人数
        public string GetAttendaceStudentCount(DateTime dt,bool isToday)
        {

            DateTime dt1 ;
            if (isToday) // 如果是当天,直接获取服务器的时间
            {
                //获取服务器的时间
               dt1= Convert.ToDateTime(SQLHelper.ExecuteScalar("select getdate()"));
                dt1 = Convert.ToDateTime(dt1.ToShortDateString());
            }
            else
            {
                dt1 = dt;
            }

            DateTime dt2= dt1.AddDays(1.0);


            string sql = "select count(distinct(CardNo)) from  Attendance where DTime between @dt1 and @dt2  ";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@dt1",dt1),
                new SqlParameter("@dt2",dt2),
            };

            try
            {
                return SQLHelper.ExecuteScalar(sql,sqlParameters).ToString();
            }
            catch (Exception ex)
            {

                throw new Exception("查询考勤人数失败: "+ex.Message);
            }

        }

        // 根据考勤卡号获取学生信息

        public Student GetStudentByCardNo(string cardNo)
        {
            string sql = "select StudentId,StudentName, Gender, Birthday, StudentIdNo, CardNo,Age, PhoneNumber, StuImage,StudentAddress, ClassName,StudentClass.ClassId from  Students inner join StudentClass on  StudentClass.ClassId =Students.ClassId where CardNo =@CardNo";
            SqlParameter[] @params = new SqlParameter[]
         {
                new SqlParameter("@CardNo",cardNo),
         };
            SqlDataReader reader = SQLHelper.ExecuteReader(sql, @params);
            Student student = new Student();
            if (reader.Read())
            {

                student.StudentId = Convert.ToInt32(reader["StudentId"]);
                student.StudentName = reader["StudentName"].ToString();
                student.Gender = reader["Gender"].ToString();
                student.Birthday = Convert.ToDateTime(reader["Birthday"]);
                student.StudentIdNo = Convert.ToString(reader["StudentIdNo"]);
                student.CardNo = Convert.ToString(reader["CardNo"]);
                student.Age = Convert.ToInt32(reader["Age"]);
                student.PhoneNumber = Convert.ToString(reader["PhoneNumber"]);
                student.StudentAddress = Convert.ToString(reader["StudentAddress"]);
                student.ClassId = Convert.ToInt32(reader["ClassId"]);
                student.ClassName = reader["ClassName"].ToString();
                // student.StuImage = reader["StuImage"].ToString();
                student.StuImage = reader["StuImage"] == null ? "" : reader["StuImage"].ToString();
            }
            else
            {
                student = null;
            }

            reader.Close();

            return student;
        }


        private Student GetStudent(string whereSql)
        {
            string sql = "select StudentId,StudentName, Gender, Birthday, StudentIdNo, CardNo,Age, PhoneNumber, StuImage,StudentAddress, ClassName,StudentClass.ClassId from  Students inner join StudentClass on  StudentClass.ClassId =Students.ClassId ";
            sql += whereSql;
       
            SqlDataReader reader = SQLHelper.ExecuteReader(sql);
            Student student = new Student();
            if (reader.Read())
            {

                student.StudentId = Convert.ToInt32(reader["StudentId"]);
                student.StudentName = reader["StudentName"].ToString();
                student.Gender = reader["Gender"].ToString();
                student.Birthday = Convert.ToDateTime(reader["Birthday"]);
                student.StudentIdNo = Convert.ToString(reader["StudentIdNo"]);
                student.CardNo = Convert.ToString(reader["CardNo"]);
                student.Age = Convert.ToInt32(reader["Age"]);
                student.PhoneNumber = Convert.ToString(reader["PhoneNumber"]);
                student.StudentAddress = Convert.ToString(reader["StudentAddress"]);
                student.ClassId = Convert.ToInt32(reader["ClassId"]);
                student.ClassName = reader["ClassName"].ToString();
                // student.StuImage = reader["StuImage"].ToString();
                student.StuImage = reader["StuImage"] == null ? "" : reader["StuImage"].ToString();
            }
            else
            {
                student = null;
            }

            reader.Close();

            return student;
        }

        // 根据时间获得考勤学生列表

        public List<Student> GetAttendanceStudentList(DateTime dt, bool isToday)
        {
            DateTime dt1;
            if (isToday) // 如果是当天,直接获取服务器的时间
            {
                //获取服务器的时间
                dt1 = Convert.ToDateTime(SQLHelper.ExecuteScalar("select getdate()"));
                dt1 = Convert.ToDateTime(dt1.ToShortDateString());
            }
            else
            {
                dt1 = dt;
            }
            DateTime dt2 = dt1.AddDays(1.0);
                     
            string sql = " select distinct(StudentId),StudentName, Gender, Students.CardNo, ClassName,DTime  from  Students\r\n  inner join StudentClass on  StudentClass.ClassId =Students.ClassId\r\n  inner join Attendance on Students.CardNo=Attendance.CardNo where DTime between @dt1 and @dt2";

            SqlParameter[] sqlParameters = new SqlParameter[]
           {
                new SqlParameter("@dt1",dt1),
                new SqlParameter("@dt2",dt2),
           };

            try
            {
                SqlDataReader reader = SQLHelper.ExecuteReader(sql, sqlParameters);

                List<Student> studentList = new List<Student> ();

                while (reader.Read())
                {
                    studentList.Add
                        (
                             new Student
                             {
                                 StudentId = Convert.ToInt32(reader["StudentId"]),
                                 StudentName = reader["StudentName"].ToString(),
                                 Gender  = reader["Gender"].ToString(),
                                 CardNo = reader["CardNo"].ToString(),
                                 ClassName = reader["ClassName"].ToString(),
                                 DTime = Convert.ToDateTime(reader["DTime"]),
                             }
                        );
                }
                reader.Close();
                return studentList;
            }
            catch (Exception)
            {

                throw;
            }


        }

        public List<Student> GetAttendanceStudentList(DateTime dt1, DateTime dt2,string stuName)
        {
           

            string sql = " select distinct(StudentId),StudentName, Gender, Students.CardNo, ClassName,DTime  from  Students\r\n  inner join StudentClass on  StudentClass.ClassId =Students.ClassId\r\n  inner join Attendance on Students.CardNo=Attendance.CardNo where DTime between @dt1 and @dt2 and StudentName=@StudentName";

            SqlParameter[] sqlParameters = new SqlParameter[]
           {
                new SqlParameter("@dt1",dt1),
                new SqlParameter("@dt2",dt2),
                new SqlParameter("@StudentName",stuName),
           };

            try
            {
                SqlDataReader reader = SQLHelper.ExecuteReader(sql, sqlParameters);

                List<Student> studentList = new List<Student>();

                while (reader.Read())
                {
                    studentList.Add
                        (
                             new Student
                             {
                                 StudentId = Convert.ToInt32(reader["StudentId"]),
                                 StudentName = reader["StudentName"].ToString(),
                                 Gender = reader["Gender"].ToString(),
                                 CardNo = reader["CardNo"].ToString(),
                                 ClassName = reader["ClassName"].ToString(),
                                 DTime = Convert.ToDateTime(reader["DTime"]),
                             }
                        );
                }
                reader.Close();
                return studentList;
            }
            catch (Exception)
            {

                throw;
            }


        }
    }
}
