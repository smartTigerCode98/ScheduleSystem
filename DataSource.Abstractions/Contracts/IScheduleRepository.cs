using System.Collections.Generic;
using System.Threading.Tasks;
using ScheduleSystem.Domain.Entities;

namespace ScheduleSystem.DataSource.Abstractions.Contracts
{
    public interface IScheduleRepository : IRepository<Schedule>
    {
        Task<Schedule> GetByGroupNameAsync(string groupName);
        Task<ICollection<Schedule>> GetByTeacherNameAsync(string teacherName);
    }
}