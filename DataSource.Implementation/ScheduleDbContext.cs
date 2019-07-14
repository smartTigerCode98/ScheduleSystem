using Microsoft.EntityFrameworkCore;
using ScheduleSystem.Domain.Entities;

namespace ScheduleSystem.DataSource.Implementation
{
	internal class ScheduleDbContext : DbContext
	{
		public DbSet<User>        Users        { get; set; }
		public DbSet<Discipline>  Disciplines  { get; set; }
		public DbSet<LectureHall> LectureHalls { get; set; }
		public DbSet<ScienceDegree> ScienceDegrees { get; set; }
		public DbSet<Teacher> Teachers { get; set; }
		public DbSet<TypeOfOccupation> TypeOfOccupations { get; set; }
		public DbSet<Schedule> Schedules { get; set; }
		

		public ScheduleDbContext(DbContextOptions options) : base(options) { }
	}
}