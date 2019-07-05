using System.Collections.Generic;

namespace DataSourceAbstractions.Contracts
{
    public interface ICrudRepository<T>
    {
        IList<T> GetAll();
        T FindById(int id);
        void Create(T entities);
        void Update(T entities);
        void Delete(T entities);
    }
}