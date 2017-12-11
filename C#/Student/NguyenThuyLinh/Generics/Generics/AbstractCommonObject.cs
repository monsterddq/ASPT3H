using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    abstract class AbstractCommonObject<T, K> : ICommonObject<T, K>
    {
        public abstract List<T> GetAll();
        public abstract void AddNew<T>(T obj);
        public abstract void Modify<T>(T obj);
        public abstract void Delete<T>(K obj);


    }
}
