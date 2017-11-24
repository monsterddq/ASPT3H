using System;
using System.Collections.Generic;
using System.Text;

namespace Lession7PhamDucLong
{
    interface ICommonObject<T, K>
    {
        List<T> GetAll();
        void AddNew(T obj);
        void Modify(T obj);
        void Delete(K s);
    }
}
