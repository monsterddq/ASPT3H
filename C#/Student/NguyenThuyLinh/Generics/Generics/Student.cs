using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
   public class Student
    {
        int StudentId { get; set; }
        string StudentName { get; set; }
        string StudentPhone { get; set; }

        public override string ToString()
        {
            return String.Format("StudentId:{0} StudentName:{1} StudentPhone:{2}", StudentId, StudentName, StudentPhone);
        }
    }
}
