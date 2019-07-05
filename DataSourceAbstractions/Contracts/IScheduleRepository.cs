using System.Collections.Generic;
using ScheduleSystem.ScheduleAPI.BusinessLogic.Entities;

namespace DataSourceAbstractions.Contracts
{
    public interface IScheduleRepository : ICrudRepository<Schedule>
    {
        Schedule FindByGroupName(string groupName);
        IList<Schedule> FindByTeacherName(string teacherName);
    }
}