using System.Collections.Generic;
using System.Threading.Tasks;
using ScheduleSystem.ScheduleAPI.BusinessLogic.Entities;

namespace DataSourceAbstractions.Contracts
{
    public interface IScheduleRepository : IRepository<Schedule>
    {
        Task<Schedule> FindByGroupName(string groupName);
        Task<IList<Schedule>> FindByTeacherName(string teacherName);
    }
}