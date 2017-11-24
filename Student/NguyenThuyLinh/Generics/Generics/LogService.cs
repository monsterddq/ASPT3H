using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class LogService : AbstractCommonObject<Log, int>
    {
        public override void AddNew<T>(T obj)
        {
            throw new NotImplementedException();
        }

        public override void Delete<T>(int obj)
        {
            throw new NotImplementedException();
        }

        public override List<Log> GetAll()
        {
            return Ulitity.ListLog;
        }

        public override void Modify<T>(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
