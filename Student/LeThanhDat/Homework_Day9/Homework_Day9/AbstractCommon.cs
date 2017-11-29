using System;
using System.Collections.Generic;

namespace Demo
{
    public abstract class AbstractCommon<T, K> : ICommonObject<T, K>
    {
        public abstract List<T> getAll();
        public abstract void addNew<T>(T obj);
        public abstract void modify<T>(T obj);
        public abstract void remove<T>(K s);
    }
}
