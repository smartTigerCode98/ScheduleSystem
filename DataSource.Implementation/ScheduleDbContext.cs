using Microsoft.EntityFrameworkCore;
using ScheduleSystem.Domain.Entities;

namespace ScheduleSystem.DataSource.Implementation
{
	public class ScheduleDbContext : DbContext
	{
		public DbSet<User>       Users       { get; set; }
		public DbSet<Discipline> Disciplines { get; set; }

		public ScheduleDbContext(DbContextOptions options) : base(options) { }
	}
}