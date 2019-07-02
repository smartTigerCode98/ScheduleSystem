using System;

namespace ScheduleSystem.ScheduleAPI.BusinessLogic.Entities
{
    public class Schedule
    {
        public int Id { get; set; }
        public Discipline Discipline { get; set; }
        public TypeOfOccupation TypeOfOccupation { get; set; }
        public Teacher Teacher { get; set; }
        public LectureHall LectureHall { get; set; }
        public DateTime Date { get; set; }
    }
}