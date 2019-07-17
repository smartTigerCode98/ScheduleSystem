using System.Collections.Generic;
using System.Threading.Tasks;
using ScheduleSystem.Domain.BysinessLayerAbstractions.Contracts.Base;
using ScheduleSystem.Domain.Entities;

namespace ScheduleSystem.Domain.BysinessLayerAbstractions.Contracts
{
    public interface IScheduleService : IService<Schedule>
    {
        Task<Schedule> GetByGroupNameAsync(string groupName);
        Task<ICollection<Schedule>> GetByTeacherNameAsync(string teacherName);
    }
}