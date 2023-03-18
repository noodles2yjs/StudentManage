    using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Models;
using GTY.DAL;

namespace DAL
{
    /// <summary>
    /// StudentClass 服务类
    /// </summary>
    
    public  class StudentClassService
    {
        public List<StudentClass> GetAllClass()
        {
            string sql = $"select ClassId, ClassName from StudentClass";

          //SqlDataReader sqlDataReader
          //      = SQLServerHelper.GetReader(sql);

            var reader = SQLHelper.ExecuteReader(sql);
            List<StudentClass> studentClasses = new List<StudentClass>();
            while (reader.Read())
            {
                studentClasses.Add(
                    new StudentClass
                    {
                        ClassId = Convert.ToInt32(reader["ClassId"]),
                        ClassName = reader["ClassName"].ToString(),
                    }
                    );
            }

            reader.Close();
            return studentClasses;
               
        }
    }
}
