using System;
using System.Collections.Generic;

namespace Demo
{
    interface ICommonObject<T, K>
    {
        List<T> getAll();
        void addNew<T>(T obj);
        void modify<T>(T obj);
        void remove<T>(K s);
    }
}
