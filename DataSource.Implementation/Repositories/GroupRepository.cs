using ScheduleSystem.DataSource.Abstractions.Contracts;
using ScheduleSystem.DataSource.Implementation.Base;
using ScheduleSystem.Domain.Entities;

namespace ScheduleSystem.DataSource.Implementation.Repositories
{
    internal sealed class GroupRepository : RepositoryBase<Group>, IGroupRepository
    {
        public GroupRepository(ScheduleDbContext dbContext) : base(dbContext) { }
    }
}