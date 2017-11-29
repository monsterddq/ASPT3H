using System;

namespace Demo
{
    public class Student
    {
        public int studentId;
        public int logId;
        public DateTime time;

        public Student()
        {

        }

        public Student(int studentId, logId, time)
        {
            this.studentId = studentId;
            this.logId = logId;
            this.time = time;
        }

        public void setId(int id)
        {
            studentId = id;
        }

        public int getId()
        {
            return studentId;
        }

        
    }
}
