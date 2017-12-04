using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public interface ICommonObject<T, K>
    {
        List<T> GetAll();
        void AddNew(T obj);
        void Modify(T obj);
        void Delete(K obj);
    }
    public abstract class AbstractCommon<T, K> : ICommonObject<T, K>
    {
        public void AddNew(T obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(K obj)
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
