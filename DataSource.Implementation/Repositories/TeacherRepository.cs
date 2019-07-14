using ScheduleSystem.DataSource.Abstractions.Contracts;
using ScheduleSystem.DataSource.Implementation.Base;
using ScheduleSystem.Domain.Entities;

namespace ScheduleSystem.DataSource.Implementation.Repositories
{
    internal sealed class TeacherRepository : RepositoryBase<Teacher>, ITeacherRepository
    {
        public TeacherRepository(ScheduleDbContext dbContext) : base(dbContext) { }
    }
}