using ScheduleSystem.ScheduleAPI.BusinessLogic.Entities;

namespace DataSourceAbstractions.Contracts
{
    public interface IRepository : IRepository<User>
    {
        User FindByEmail(string email);
    }
}