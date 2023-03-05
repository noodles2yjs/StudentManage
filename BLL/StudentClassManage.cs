using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class StudentClassManage
    {
        private StudentClassService service= new StudentClassService();
        public List<StudentClass> GetAllClass() 
        { 
            return service.GetAllClass();
        }
    }
}
