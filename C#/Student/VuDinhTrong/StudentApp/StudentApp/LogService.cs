using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class LogService : AbstractCommon<Log, int>
    {
        public override void AddNew(Log obj)
        {
            throw new NotImplementedException();
        }

        public override void Delete(int key)
        {
            throw new NotImplementedException();
        }

        public override List<Log> GetAll()
        {
            throw new NotImplementedException();
        }

        public override void Modify(Log obj)
        {
            throw new NotImplementedException();
        }
    }
}