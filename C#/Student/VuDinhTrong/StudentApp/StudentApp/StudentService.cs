using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class StudentService : AbstractCommon<Student, int>
    {
        public override void AddNew(Student obj)
        {
            throw new NotImplementedException();
        }

        public override void Delete(int key)
        {
            throw new NotImplementedException();
        }

        public override List<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public override void Modify(Student obj)
        {
            throw new NotImplementedException();
        }
    }
}