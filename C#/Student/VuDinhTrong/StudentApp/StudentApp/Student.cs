using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentPhone { get; set; }

        public Student(){}
        public Student(int StudentId, string StudentName, string StudentPhone)
        {
        this.StudentId = StudentId;
        this.StudentName = StudentName;
        this.StudentPhone = StudentPhone;
        }
    }
}
