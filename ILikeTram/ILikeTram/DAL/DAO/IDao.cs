using System.Collections.Generic;

namespace ILikeTram.DAL.DAO
{
    public interface IDao<T>
    {
        void Add(T instance);

        void Update(T instance);

        void Delete(T instance);

        T Read(string name);

        List<T> ReadAll();
    }
}
