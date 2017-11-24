using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAT
{
    public interface ICommonRepository
    {
        List<T> GetAll<T>();
        T Find<T>(string code);
        T Add<T>(T t);
        T Modify<T>(T t);
        bool Remove(string code);
    }
}
