using ScheduleSystem.DataSource.Abstractions.Contracts;
using ScheduleSystem.DataSource.Implementation.Base;
using ScheduleSystem.Domain.Entities;

namespace ScheduleSystem.DataSource.Implementation.Repositories
{
    internal sealed class TypeOfOccupationRepository : RepositoryBase<TypeOfOccupation>, ITypeOfOccupationRepository
    {
        public TypeOfOccupationRepository(ScheduleDbContext dbContext) : base(dbContext) { }
    }
}