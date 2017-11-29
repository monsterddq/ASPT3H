using System;
using System.Collections.Generic;
using System.Text;

namespace Lession7PhamDucLong
{
    class AbstractCommon<T, K> : ICommonObject<T, K>
    {
        private List<T> listT;

        public List<T> ListT { get => listT; set => listT = value; }

        public void AddNew(T obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(K s)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
             
        }

        public void Modify(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
