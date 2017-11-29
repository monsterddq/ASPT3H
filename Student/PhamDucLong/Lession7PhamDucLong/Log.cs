using System;
using System.Collections.Generic;
using System.Text;

namespace Lession7PhamDucLong
{
    class Log
    {
        public int Id
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }

        public Log(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Log()
        {
        }
    }
}
