using System.Threading.Tasks;
using ScheduleSystem.ScheduleAPI.BusinessLogic.Entities;

namespace DataSourceAbstractions.Contracts
{
    public interface IRepository : IRepository<User>
    {
        Task<User> FindByEmail(string email);
    }
}