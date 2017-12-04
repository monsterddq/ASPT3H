using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;

namespace StudentApp
{
    internal interface ICommonObject<T, K>
    {
        List<T> GetAll();

        void AddNew(T obj);

        void Modify(T obj);

        void Delete(K key);
    }
}