using System.Threading.Tasks;
using ScheduleSystem.Domain.BysinessLayerAbstractions.Contracts.Base;
using ScheduleSystem.Domain.Entities;

namespace ScheduleSystem.Domain.BysinessLayerAbstractions.Contracts
{
    public interface IUserService : IService<User>
    {
        Task<User> GetUserByEmail(string email);
    }
}