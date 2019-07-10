using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using ScheduleSystem.DataSource.Abstractions.Contracts;
using ScheduleSystem.Domain.Entities;

namespace ScheduleSystem.DataSource.Implementation.MockDataSource
{
    public class ScheduleRepository : IScheduleRepository
    {
        /*
        private Collection<Schedule> _schedules = new Collection<Schedule>
        {
            new Schedule()
        }
        */
        public Task<Schedule> GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<ICollection<Schedule>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(Schedule entities)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(Schedule entities)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateAsync(Schedule entities)
        {
            throw new System.NotImplementedException();
        }

        public Task<Schedule> GetByGroupNameAsync(string groupName)
        {
            throw new System.NotImplementedException();
        }

        public Task<IList<Schedule>> GetByTeacherNameAsync(string teacherName)
        {
            throw new System.NotImplementedException();
        }
    }
}