using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ScheduleSystem.DataSource.Abstractions.Contracts;
using ScheduleSystem.DataSource.Implementation.Base;
using ScheduleSystem.Domain.Entities;

namespace ScheduleSystem.DataSource.Implementation.Repositories
{
    internal sealed class ScheduleRepository : RepositoryBase<Schedule>, IScheduleRepository
    {
        public ScheduleRepository(ScheduleDbContext dbContext) : base(dbContext)
        {
        }

        public Task<Schedule> GetByGroupNameAsync(string groupName)
        {
            return DbSet.FirstOrDefaultAsync(schedule => schedule.Group.Name == groupName);
        }

        public async Task<IList<Schedule>> GetByTeacherNameAsync(string teacherName)
        {
            return await DbSet.Where(schedule => schedule.Teacher.Name == teacherName).ToListAsync();
        }
    }
}