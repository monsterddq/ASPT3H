using System.Collections.Generic;

namespace StudentApp
{
    internal abstract class AbstractCommon<T, K> : ICommonObject<T, K>
    {
        public StudentDBContext db = new StudentDBContext();

        public abstract void AddNew(T obj);

        public abstract void Modify(T obj);

        public abstract void Delete(K key);

        public abstract List<T> GetAll();
    }
}