using ScheduleSystem.DataSource.Abstractions.Contracts;
using ScheduleSystem.DataSource.Implementation.Base;
using ScheduleSystem.Domain.Entities;

namespace ScheduleSystem.DataSource.Implementation.Repositories
{
    internal sealed class ScienceDegreeRepository : RepositoryBase<ScienceDegree>, IScienceDegreeRepository
    {
        public ScienceDegreeRepository(ScheduleDbContext dbContext) : base(dbContext) { }
    }
}