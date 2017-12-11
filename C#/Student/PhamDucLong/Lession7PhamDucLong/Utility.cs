using System;
using System.Collections.Generic;
using System.Text;

namespace Lession7PhamDucLong
{
    static class Utility<T>
    {
        static List<T> listT = new List<T>();
        static List<Student> listStudent = new List<Student>();
        static List<Log> listLog = new List<Log>();

        public static List<Student> ListStudent { get => listStudent; set => listStudent = value; }
        public static List<Log> ListLog { get => listLog; set => listLog = value; }
        public static List<T> ListT { get => listT; set => listT = value; }
    }
}
