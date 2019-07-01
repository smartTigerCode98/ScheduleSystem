namespace ScheduleSystem.ScheduleAPI.BusinessLogic.Entities
{
    public class LectureHall
    {
        public int Id {get; set;}
        public string Number { get; set; }
        public bool IsFree { get; set; }

        public LectureHall(string number, bool isFree)
        {
            Number = number;
            IsFree = isFree;
        }
    }
}