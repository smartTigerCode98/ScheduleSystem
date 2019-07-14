using System;
using ScheduleSystem.Domain.Entities.Contracts;

namespace ScheduleSystem.Domain.Entities
{
    public class Group : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StudentsQuantity { get; set; }
    }
}