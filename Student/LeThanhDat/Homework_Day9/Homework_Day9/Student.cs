using System;

namespace Demo
{
    public class Student
    {
        public int studentId;
        public string studentName;
        public string studentPhone;

        public Student()
        {

        }

        public Student(int id, string name, string phone)
        {
            studentId = id;
            studentName = name;
            studentPhone = phone;
        }

        public void setId(int id)
        {
            studentId = id;
        }

        public int getId()
        {
            return studentId;
        }

        public void setName(string name)
        {
            studentName = name;
        }

        public string getName()
        {
            return studentName;
        }

        public void setPhone(string phone)
        {
            studentPhone = phone;
        }

        public string getPhone()
        {
            return studentPhone;
        }
    }
}
