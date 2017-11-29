using System;
using System.Collections.Generic;
using System.Text;

namespace Lession7PhamDucLong
{
    class StudentService : AbstractCommon<Student, int>
    {
        public StudentService()
        {

        }

        public List<Student> GetAll()
        {
            base.GetAll();
        }

    }
}
