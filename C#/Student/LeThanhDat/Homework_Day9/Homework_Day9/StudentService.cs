using System;
using System.Collections.Generic;

namespace Demo
{
    public class StudentService : AbstractCommon<Student, int>
    {
        public List<Student> getAll()
        {
            foreach (var student in studentList)
            {
                Console.WriteLine(student.studentId);
                Console.WriteLine(student.studentName);
                Console.WriteLine(student.studentPhone);
            }
        }

        public void addNew(Student student)
        {
            studentList.Add(student);
        }

        public void modify(Student student)
        {
            return;
        }

        public void remove(int studentId)
        {
            foreach (var student in studentList)
            {
                if (student.studentId == studentId)
                {
                    studentList.Remove(student);
                }
            }
        }
    }
}
