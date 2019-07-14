using ScheduleSystem.Domain.Entities.Contracts;

namespace ScheduleSystem.Domain.Entities
{
    public class ScienceDegree : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}