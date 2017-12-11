using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Entinity
{
    public class log
    {
        public int LogId { get; set; }
        public string LogName { get; set; }
        public log(int LogId, string LogName)
        {
            this.LogId = LogId;
            this.LogName = LogName;
        }
        public log()
        {

        }
    }
}
