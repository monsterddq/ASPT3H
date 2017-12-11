using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    class Log
    {
        public int LogId { get; set; }

        public string LogName { get; set; }

        public Log(){}
        public Log(int LogId, string LogName)
        {
            this.LogId = LogId;
        this.LogName = LogName;
       
        }
    }
}
