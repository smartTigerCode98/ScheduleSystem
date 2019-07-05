using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataSourceAbstractions.Contracts
{
    public interface IRepository<T>
    {
        Task<T> FindById(int id);
        Task<IList<T>> FindAll();
        Task Create(T entities);
        Task Update(T entities);
        Task Delete(T entities);
    }
}