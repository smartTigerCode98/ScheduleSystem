using ScheduleSystem.Domain.Entities.Contracts;

namespace ScheduleSystem.Domain.Entities
{
	public class LectureHall : IEntity
	{
		public int    Id       { get; set; }
		public string Number   { get; set; }
		public int    Capacity { get; set; }
	}
}