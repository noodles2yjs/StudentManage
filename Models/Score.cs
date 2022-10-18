using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// ScoreList 实体类
    /// </summary>
    [Serializable]
    public class Score
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int Csharp { get; set; }
        public int SQLServerDB { get; set; }
        public DateTime? UpdateTime { get; set; }

    }
}
