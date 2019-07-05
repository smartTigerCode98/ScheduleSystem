using System.Threading.Tasks;
using ScheduleSystem.Domain.Entities;

namespace ScheduleSystem.DataSource.Abstractions.Contracts
{
    public interface IRepository : IRepository<User>
    {
        Task<User> GetByEmailAsync(string email);
    }
}