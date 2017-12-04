using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Student.Entinity
{
    public class student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set;}
        public string StudentPhone { get; set; }
        public student(int StudentId, string StudentName, String StudentPhone)
        {
            this.StudentId = StudentId;
            this.StudentName = StudentName;
            this.StudentPhone = StudentPhone;
        }
        public student()
        {

        }
    }
}
