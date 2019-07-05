using ScheduleSystem.ScheduleAPI.BusinessLogic.Entities;

namespace DataSourceAbstractions.Contracts
{
    public interface IUserRepository : ICrudRepository<User>
    {
        User FindByEmail(string email);
    }
}