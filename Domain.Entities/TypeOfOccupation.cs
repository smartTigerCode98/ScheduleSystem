using ScheduleSystem.Domain.Entities.Contracts;

namespace ScheduleSystem.Domain.Entities
{
    public class TypeOfOccupation : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}