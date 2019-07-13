using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ScheduleSystem.DataSource.Abstractions.Contracts;
using ScheduleSystem.DataSource.Implementation.Base;
using ScheduleSystem.Domain.Entities;

namespace ScheduleSystem.DataSource.Implementation.Repositories
{
	internal sealed class DisciplineRepository : RepositoryBase<Discipline>, IDisciplineRepository
	{
		public DisciplineRepository(ScheduleDbContext dbContext) : base(dbContext) { }

		public Task<Discipline> GetDisciplineByName(string name)
		{
			return DbSet.FirstOrDefaultAsync(d => d.Name == name);
		}
	}
}