using System.Collections.Generic;
using System.Threading.Tasks;

namespace ScheduleSystem.Domain.BysinessLayerAbstractions.Contracts.Base
{
    public interface IService<T>
    {
        Task Add(T entity);
        Task Delete(T entity);
        Task Update(T entity);
        Task<T> GetById(int id);
        Task<ICollection<T>> GetAll();
    }
}