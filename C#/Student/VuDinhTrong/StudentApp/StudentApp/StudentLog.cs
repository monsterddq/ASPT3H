using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    class StudentLog
    {
        public int StudentId { get; set; }

        public int LogId { get; set; }

        public DateTime Time {get; set; }
        public StudentLog(){}
        public StudentLog(int StudentId,int LogId,DateTime Time){
        this.StudentId = StudentId;
        this.LogId = LogId;
        this.Time = Time;
        }
    }
}
