using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    interface ICommonObject<T, K>
    {
        List<T> GetAll();
        void AddNew<T>(T obj);
        void Modify<T>(T obj);
        void Delete<T>(K s);
    }
}
