using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GTY.DAL;
using Models;

namespace DAL
{
    /// <summary>
    /// Students 服务类
    /// </summary>

    public class StudentService
    {
        /// <summary>
        ///  验证身份证号是否重复
        /// </summary>
        /// <param name="stuIdNo"></param>
        /// <returns></returns>
        public bool IsIDExisted(string stuIdNo)
        {
            //string sql = $"select count(0) from Students where StudentIdNo = {stuIdNo} ";

            string sql2 = "select count(0) from Students where StudentIdNo = @StudentIdNo";

            SqlParameter[] @params = new SqlParameter[]
            {
                new SqlParameter("@StudentIdNo",stuIdNo),
            };
            var res = Convert.ToInt32(SQLHelper.ExecuteScalar(sql2, @params));
            /* if (res ==1)
             {
                 return true;
             }
             else
             {
                 return false;
             }*/

            return res == 1;
        }
        public bool IsIDExisted(string stuIdNo,string stuId)
        {
            //string sql = $"select count(0) from Students where StudentIdNo = {stuIdNo} ";

            string sql2 = "select count(0) from Students where StudentIdNo = @StudentIdNo and StudentId <> @StudentId";

            SqlParameter[] @params = new SqlParameter[]
            {
                new SqlParameter("@StudentIdNo",stuIdNo),
                new SqlParameter("@StudentId",stuId),
            };
            var res = Convert.ToInt32(SQLHelper.ExecuteScalar(sql2, @params));
            /* if (res ==1)
             {
                 return true;
             }
             else
             {
                 return false;
             }*/

            return res == 1;
        }
        // 验证卡号是否存在
        public bool IsCardIdExisted(string cardNo)
        {
            //string sql = $"select count(0) from Students where CardNo ='{cardNo}'";
            string sql2 = "select count(0) from Students where CardNo =@CardNo";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@CardNo",cardNo),
            };


            var res = Convert.ToInt32(SQLHelper.ExecuteScalar(sql2,sqlParameters));
            return res == 1;
        }
        /// <summary>
        /// 添加学生
        /// </summary>
        /// <returns></returns>
        public int AddStudent(Student  student)
        {
            //string sql = $"insert into Students values ('{student.StudentName}','{student.Gender}','{student.Birthday}',{student.StudentIdNo},'{student.CardNo}','{student.StuImage}',{student.Age},'{student.PhoneNumber}','{student.StudentAddress}',{student.ClassId});select @@Identity";


            string sql2 = $"insert into Students(StudentName, Gender, Birthday, StudentIdNo, CardNo, StuImage, Age, PhoneNumber, StudentAddress, ClassId) values (@StudentName, @Gender, @Birthday, @StudentIdNo, @CardNo, @StuImage, @Age, @PhoneNumber, @StudentAddress, @ClassId);select @@Identity";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@StudentName",student.StudentName),
                new SqlParameter("@Gender",student.Gender),
                new SqlParameter("@Birthday",student.Birthday),
                new SqlParameter("@StudentIdNo",student.StudentIdNo),
                new SqlParameter("@CardNo",student.CardNo),
                new SqlParameter("@StuImage",student.StuImage),
                new SqlParameter("@Age",student.Age),
                new SqlParameter("@PhoneNumber",student.PhoneNumber),
                new SqlParameter("@StudentAddress",student.StudentAddress),
                new SqlParameter("@ClassId",student.ClassId),
            };

            try
            {
                return Convert.ToInt32(SQLHelper.ExecuteScalar(sql2,sqlParameters)) ;
            }
            catch (SqlException ex)
            {
                
                throw new Exception("数据库操作出现异常! 具体信息: \r\n" + ex.Message);
            }

            catch (Exception ex)
            {

                throw ex;
            }
        }
        /// <summary>
        /// 用在添加学生页面,查询已有的学生
        /// </summary>
        /// <returns></returns>
        public DataSet QueryAllStudents()
        {

            string sql = "select s.*,ClassName from Students as s\r\ninner join StudentClass on s.ClassId= StudentClass.ClassId";

            try
            {
              return  SQLHelper.GetDataSet(sql);
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        /// <summary>
        /// 根据班级名称查询学生
        /// </summary>
        /// <returns></returns>
        public List<Student> GetStudentsByClassName(string className)
        {
            string sql = " select StudentId, StudentName, Gender, Birthday, StudentIdNo, CardNo,Age, PhoneNumber, StudentAddress, StudentClass.ClassId from  Students inner join StudentClass on  StudentClass.ClassId =Students.ClassId where ClassName =@ClassName";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@ClassName",className),
            };

            try
            {
                SqlDataReader reader = SQLHelper.ExecuteReader(sql, sqlParameters);
                List<Student> studentList = new List<Student>();
                while (reader.Read())
                {
                    studentList.Add
                        (
                        new Student()
                        {
                            StudentId = Convert.ToInt32(reader["StudentId"]),
                            StudentName = reader["StudentName"].ToString(),
                            Gender = reader["Gender"].ToString(),
                            Birthday = Convert.ToDateTime(reader["Birthday"]),
                            StudentIdNo = Convert.ToString(reader["StudentIdNo"]),
                            CardNo = Convert.ToString(reader["CardNo"]),
                            Age = Convert.ToInt32(reader["Age"]),
                            PhoneNumber = Convert.ToString(reader["PhoneNumber"]),
                            StudentAddress = Convert.ToString(reader["StudentAddress"]),
                            ClassId = Convert.ToInt32(reader["ClassId"]),
                            ClassName = className,
                        }
                        ) ;
                }
                reader.Close();

                return studentList;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Student> GetAllStudents()
        {
            string sql = " select StudentId, StudentName,ClassName,Gender, Birthday, StudentIdNo, CardNo,Age, PhoneNumber, StudentAddress, StudentClass.ClassId from  Students inner join StudentClass on  StudentClass.ClassId =Students.ClassId";

            try
            {
                SqlDataReader reader = SQLHelper.ExecuteReader(sql);
                List<Student> studentList = new List<Student>();
                while (reader.Read())
                {
                    studentList.Add
                        (
                        new Student()
                        {
                            StudentId = Convert.ToInt32(reader["StudentId"]),
                            StudentName = reader["StudentName"].ToString(),
                            Gender = reader["Gender"].ToString(),
                            Birthday = Convert.ToDateTime(reader["Birthday"]),
                            StudentIdNo = Convert.ToString(reader["StudentIdNo"]),
                            CardNo = Convert.ToString(reader["CardNo"]),
                            Age = Convert.ToInt32(reader["Age"]),
                            PhoneNumber = Convert.ToString(reader["PhoneNumber"]),
                            StudentAddress = Convert.ToString(reader["StudentAddress"]),
                            ClassId = Convert.ToInt32(reader["ClassId"]),
                            ClassName = reader["ClassName"].ToString(),
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
        //根据学号查询学生信息
        public Student GetStudnetByStudentyId(string studentId)
        {
            string sql= "select StudentName, Gender, Birthday, StudentIdNo, CardNo,Age, PhoneNumber, StuImage,StudentAddress, ClassName,StudentClass.ClassId from  Students inner join StudentClass on  StudentClass.ClassId =Students.ClassId where StudentId =@StudentId";
            SqlParameter[] @params = new SqlParameter[]
         {
                new SqlParameter("@StudentId",studentId),
         };
            SqlDataReader reader = SQLHelper.ExecuteReader(sql, @params);
            Student student = new Student();
            if (reader.Read())
            {

                student.StudentId = Convert.ToInt32(studentId);
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
        /// <summary>
        /// 修改操作
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public int ModifyStudent(Student student)
        {
            string sql = " update Students set  StudentName=@StudentName, Gender=@Gender, Birthday=@Birthday, StudentIdNo=@StudentIdNo, CardNo=@CardNo, StuImage=@StuImage, Age=@Age, PhoneNumber=@PhoneNumber, StudentAddress=@StudentAddress, ClassId=@ClassId where StudentId=@StudentId";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@StudentName",student.StudentName),
                new SqlParameter("@Gender",student.Gender),
                new SqlParameter("@Birthday",student.Birthday),
                new SqlParameter("@StudentIdNo",student.StudentIdNo),
                new SqlParameter("@StuImage",student.StuImage),
                new SqlParameter("@Age",student.Age),
                new SqlParameter("@PhoneNumber",student.PhoneNumber),
                new SqlParameter("@StudentAddress",student.StudentAddress),
                new SqlParameter("@ClassId",student.ClassId),
                new SqlParameter("@StudentId",student.StudentId),
                new SqlParameter("@CardNo",student.CardNo),
            };

            try
            {
                return SQLHelper.ExecuteNonQuery(sql, sqlParameters);
            }
            catch (Exception)
            {

                throw;
            }


        }

        public int DeleteStudent(string studentId) 
        {
            string sql = "delete from Students where StudentId=@StudentId";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@StudentId",studentId),

            };

            try
            {
                return SQLHelper.ExecuteNonQuery(sql, sqlParameters); 
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
