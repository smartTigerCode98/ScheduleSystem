using System.Collections.Generic;
using System.Threading.Tasks;
using ScheduleSystem.Domain.Entities;

namespace ScheduleSystem.Domain.BysinessLayerAbstractions.Contracts
{
    public interface IScheduleService
    {
        Task<ICollection<Schedule>> GetAll();
        Task Update(Schedule schedule);
        Task Delete(Schedule schedule);
        Task Add(Schedule schedule);
        Task<Schedule> GetByGroupNameAsync(string groupName);
        Task<ICollection<Schedule>> GetByTeacherNameAsync(string teacherName);
    }
}