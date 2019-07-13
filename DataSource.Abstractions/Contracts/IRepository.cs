using System.Collections.Generic;
using System.Threading.Tasks;

namespace ScheduleSystem.DataSource.Abstractions.Contracts
{
    public interface IRepository<T>
    {
        Task<T> GetByIdAsync(int id);
        Task<ICollection<T>> GetAllAsync();
        
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);

        Task SaveChangesAsync();
    }
}