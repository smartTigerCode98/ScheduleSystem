using System.Collections.Generic;
using ScheduleSystem.ScheduleAPI.BusinessLogic.Entities;

namespace DataSourceAbstractions.Contracts
{
    public interface IScheduleRepository : IRepository<Schedule>
    {
        Schedule FindByGroupName(string groupName);
        IList<Schedule> FindByTeacherName(string teacherName);
    }
}