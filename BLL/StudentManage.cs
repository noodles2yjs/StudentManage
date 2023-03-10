using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class StudentManage
    {
        private StudentService service = new StudentService();
        public bool IsIDExisted(string stuIdNo)
        {
            return service.IsIDExisted(stuIdNo);
        }
        public bool IsIDExisted(string stuIdNo, string stuId)
        {
            return service.IsIDExisted(stuIdNo, stuId);
        }
        public bool IsCardIdExisted(string cardNo)
        {
            return service.IsCardIdExisted(cardNo);
        }

        public int AddStudent(Student student)
        {
            return service.AddStudent(student);
        }
        /// <summary>
        /// 用在添加学生页面,查询已有的学生
        /// </summary>
        /// <returns></returns>
        public DataSet QueryAllStudents()
        {
           return service.QueryAllStudents();
        }

        /// <summary>
        /// 根据班级查询数据
        /// </summary>
        /// <param name="className"></param>
        /// <returns></returns>
        public List<Student> GetStudentsByClassName(string className)
        {
            return service.GetStudentsByClassName(className);
        }

        public Student GetStudnetByStudentyId(string studentId)
        {
            return service.GetStudnetByStudentyId(studentId);
        }
        public List<Student> GetAllStudents()
        {
            return service.GetAllStudents();
        }

        public int ModifyStudent(Student student)
        {
            return service.ModifyStudent(student);
        }

        public int DeleteStudent(string studentId)
        {
            return service.DeleteStudent(studentId);
        }
    }
}
