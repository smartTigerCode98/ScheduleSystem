using ScheduleSystem.Domain.Entities.Contracts;

namespace ScheduleSystem.Domain.Entities
{
	public class Discipline : IEntity
	{
		public int    Id      { get; set; }
		public string Name    { get; set; }
		public int    Credits { get; set; }
	}
}