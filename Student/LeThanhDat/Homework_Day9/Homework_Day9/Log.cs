using System;

namespace Demo
{
    public class Log
    {
        public int logId;
        public string logName;

        public Log()
        {

        }

        public Log(int id, string name)
        {
            logId = id;
            logName = name;
        }

        public void setId(int id)
        {
            logId = id
        }

        public int getId()
        {
            return logId
        }

        public void setName(string name)
        {
            logName = name;
        }

        public string getName()
        {
            return logName;
        }

    }
}
