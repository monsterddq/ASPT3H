using System;
using System.Collections.Generic;

namespace Demo
{
    public class LogService : AbstractCommon<Student, int>
    {
        public List<Log> getAll()
        {
            foreach (var log in listLog)
            {
                Console.WriteLine(log.getId());
                Console.WriteLine(log.getName());
            }
        }

        public void addNew(Log log)
        {
            listLog.Add(log);
        }

        public void modify(Log log)
        {
            return;
        }

        public void remove(int logId)
        {
            foreach (var log in listLog)
            {
                if (log.getId == logId)
                {
                    studentList.Remove(log);
                }
            }
        }
    }
}
