using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Generics
{
     class StudentService : AbstractCommonObject<Student, int>
    {
        public override List<Student> GetAll()
        {
            return Ulitity.ListStudent;
        }

        public override void AddNew<Student>(Student obj)
        {
            var r = Ulitity.ListStudent.Find(w => w.Equals(obj));
            Ulitity.ListStudent.Add(r);
        }

        public override void Delete<Student>(int s)
        {
            var r = Ulitity.ListStudent.Find(w => w.Equals(s));
            if (r == null)
                throw new Exception();
            else
            {
                Ulitity.ListStudent.Remove(r);
            }
        }

        public override void Modify<T>(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
