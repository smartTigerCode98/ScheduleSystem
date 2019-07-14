using System;
using ScheduleSystem.Domain.Entities.Contracts;

namespace ScheduleSystem.Domain.Entities
{
    public class Schedule : IEntity
    {
        public int Id { get; set; }
        public Group Group { get; set; }
        public Discipline Discipline { get; set; }
        public TypeOfOccupation TypeOfOccupation { get; set; }
        public Teacher Teacher { get; set; }
        public LectureHall LectureHall { get; set; }
        public DateTime Date { get; set; }
    }
}