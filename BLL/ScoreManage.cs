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
    public class ScoreManage
    {
        private ScoreService service = new ScoreService();
        public DataSet GetAllScoreList()
        {
            return service.GetAllScoreList();
        }

        public List<ExtStudent> GetScoreList(string className)
        {
            return service.GetScoreList(className);
        }

        public Dictionary<string, string> GetClassStatInfo(string classId)
        {
            return service.GetClassStatInfo(classId);
        }

        public List<string> GetAbsentStudentNameList(string classId)
        {
            return service.GetAbsentStudentNameList(classId);
        }
    }
}
