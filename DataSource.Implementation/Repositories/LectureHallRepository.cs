using ScheduleSystem.DataSource.Abstractions.Contracts;
using ScheduleSystem.DataSource.Implementation.Base;
using ScheduleSystem.Domain.Entities;

namespace ScheduleSystem.DataSource.Implementation.Repositories
{
    internal sealed class LectureHallRepository : RepositoryBase<LectureHall>, ILectureHallRepository
    {
        public LectureHallRepository(ScheduleDbContext dbContext) : base(dbContext) { }
    }
}