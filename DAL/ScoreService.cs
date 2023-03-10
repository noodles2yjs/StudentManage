using GTY.DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// ScoreList 服务类
    /// </summary>

    public class ScoreService
    {

        public DataSet GetAllScoreList()
        {
            string sql = "select Students.StudentId, StudentName,PhoneNumber, Gender, Students.ClassId,ClassName,CSharp,SQLServerDB from Students inner join StudentClass on Students.ClassId = StudentClass.ClassId inner join ScoreList on ScoreList.StudentId = Students.StudentId ";

            try
            {
                return SQLHelper.GetDataSet(sql);
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 成绩分析:根据班级查询成绩/查询全校的成绩
        /// </summary>
        /// <returns></returns>
        public List<ExtStudent> GetScoreList(string className)
        {
            string sql = "select distinct(Students.StudentId),StudentName,Gender,ClassName,CSharp,SQLServerDB from Students \r\ninner join StudentClass on StudentClass.ClassId = Students.ClassId\r\ninner join ScoreList on Students.StudentId = ScoreList.StudentId ";

            SqlParameter[] sqlParameters = null;
            if (className != null && className.Length > 0)
            {
                sql += " where ClassName=@ClassName";
                sqlParameters = new SqlParameter[]
           {
                new SqlParameter("@ClassName",className),
           };

            }




            try
            {
                SqlDataReader reader = SQLHelper.ExecuteReader(sql, sqlParameters);
                List<ExtStudent> extStudentList = new List<ExtStudent>();

                while (reader.Read())
                {
                    extStudentList.Add(
                        new ExtStudent
                        {
                            Student = new Student
                            {
                                StudentId = Convert.ToInt32(reader["StudentId"]),
                                StudentName = reader["StudentName"].ToString(),
                                Gender = reader["Gender"].ToString(),

                            },
                            ClassName = reader["ClassName"].ToString(),
                            ScoreList = new ScoreList
                            {
                                Csharp = Convert.ToInt32(reader["Csharp"]),
                                SQLServerDB = Convert.ToInt32(reader["SQLServerDB"])
                            }
                        }

                        );
                }

                reader.Close();

                return extStudentList;
            }
            catch (Exception)
            {

                throw;
            }
        }

        #region 统计班级考试信息/或者全校信息

        public Dictionary<string, string> GetClassStatInfo(string classId)
        {
            StringBuilder sql = new StringBuilder();
            SqlParameter[] sqlParameters = null;
            if (classId != null && classId.Length > 0)
            {

                sql.Append("select  stuCount = count(distinct(Students.StudentId)),avgCSharp=avg(CSharp),avgDB=avg(SqlserverDB) from ScoreList \r\ninner join Students on Students.StudentId = ScoreList.StudentId where ClassId =@ClassId;");
                sql.Append("select absentCount=count(0) from Students where StudentId not in (select StudentId from ScoreList) and  ClassId =@ClassId; ");
                sqlParameters = new SqlParameter[]
                {
                new SqlParameter("@ClassId",classId),
                };


            }
            else
            {
                sql.Append("select  stuCount = count(distinct(Students.StudentId)),avgCSharp=avg(CSharp),avgDB=avg(SqlserverDB) from ScoreList \r\ninner join Students on Students.StudentId = ScoreList.StudentId; ");
                sql.Append("select absentCount=count(0) from Students where StudentId not in (select StudentId from ScoreList) ; ");
            }
            

            try
            {
                var reader = SQLHelper.ExecuteReader(sql.ToString(), sqlParameters);

                Dictionary<string, string> scoreInfo = new Dictionary<string, string>();
                if (reader.Read())
                {
                    if (!scoreInfo.Keys.Contains("stuCount"))
                    {
                        scoreInfo.Add("stuCount", reader["stuCount"].ToString());
                    }
                    else
                    {
                        scoreInfo["stuCount"] = reader["stuCount"].ToString();
                    }

                    if (!scoreInfo.Keys.Contains("avgCSharp"))
                    {
                        scoreInfo.Add("avgCSharp", reader["avgCSharp"].ToString());
                    }
                    else
                    {
                        scoreInfo["avgCSharp"] = reader["avgCSharp"].ToString();
                    }

                    if (!scoreInfo.Keys.Contains("avgDB"))
                    {
                        scoreInfo.Add("avgDB", reader["avgDB"].ToString());
                    }
                    else
                    {
                        scoreInfo["avgDB"] = reader["avgDB"].ToString();
                    }


                }
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        if (!scoreInfo.Keys.Contains("absentCount"))
                        {
                            scoreInfo.Add("absentCount", reader["absentCount"].ToString());
                        }
                        else
                        {
                            scoreInfo["absentCount"] = reader["absentCount"].ToString();
                        }

                    }
                }

                reader.Close();
                return scoreInfo;
            }
            catch (Exception)
            {

                throw;
            }

        }

        // 缺考人员名单
        public List<string> GetAbsentStudentNameList(string classId)
        {
            string sql = "select StudentName from Students where StudentId not in (select StudentId from ScoreList) ";
            SqlParameter[] sqlParameters = null;
            if (classId != null && classId.Length > 0)
            {
                // sql.Append("and ClassId =@ClassId;");
                sql += "  and ClassId =@ClassId;";
                sqlParameters = new SqlParameter[]
                {
                new SqlParameter("@ClassId",classId),
                };
            }



            try
            {
                SqlDataReader reader = SQLHelper.ExecuteReader(sql, sqlParameters);
                List<string> absentStudentList = new List<string>();

                while (reader.Read())
                {
                    absentStudentList.Add(reader["StudentName"].ToString());
                }
                reader.Close();
                return absentStudentList;
            }
            catch (Exception)
            {

                throw;
            }

        }
        #endregion


    }
}
