namespace ScheduleSystem.Domain.Entities
{
    public class LectureHall
    {
        public int Id {get; set;}
        public string Number { get; set; }

        public LectureHall(int id, string number)
        {
            Id = id;
            Number = number;
        }
    }
}