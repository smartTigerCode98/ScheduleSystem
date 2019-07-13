using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ScheduleSystem.DataSource.Abstractions.Contracts;
using ScheduleSystem.DataSource.Implementation.Base;
using ScheduleSystem.Domain.Entities;

namespace ScheduleSystem.DataSource.Implementation.Repositories
{
	internal sealed class UserRepository : RepositoryBase<User>, IUserRepository
	{
		public UserRepository(ScheduleDbContext dbContext) : base(dbContext) { }
		
		public Task<User> GetByEmailAsync(string email)
		{
			return DbSet.FirstOrDefaultAsync(u => u.Email == email);
		}
	}
}