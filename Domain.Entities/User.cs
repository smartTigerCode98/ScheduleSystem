using ScheduleSystem.Domain.Entities.Contracts;

namespace ScheduleSystem.Domain.Entities
{
	public class User : IEntity
	{
		public int    Id           { get; set; }
		public string Email        { get; }
		public string PasswordHash { get; }
	}
}