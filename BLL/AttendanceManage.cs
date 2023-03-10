using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AttendanceManage
    {
        private AttendanceService service = new AttendanceService();

        public string AddRecord(string cardNo)
        {
            return service.AddRecord(cardNo);
        }
        public string GetAllStudentCount()
        {
            return service.GetAllStudentCount();
        }

        public string GetAttendaceStudentCount(DateTime dt, bool isToday)
        {
            return service.GetAttendaceStudentCount(dt, isToday);
        }

        public Student GetStudentByCardNo(string cardNo)
        {
            return service.GetStudentByCardNo(cardNo);
        }

      

        public List<Student> GetAttendanceStudentList(DateTime dt, bool isToday)
        {
            return service.GetAttendanceStudentList(dt, isToday);
        }

        public List<Student> GetAttendanceStudentList(DateTime dt1, DateTime dt2, string stuName)
        {
          return  service.GetAttendanceStudentList(dt1, dt2, stuName);
        }
    }
}
