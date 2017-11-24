using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLS
{
    public class StudentService : AbstractCommonObject<Student, int>, ICommonObject<Student, int>
    {
        public override List<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public override void AddNew<T>(T obj)
        {
            throw new NotImplementedException();
        }

        public override void Delete<T>(int obj)
        {
            throw new NotImplementedException();
        }

        public override void Modify<T>(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
