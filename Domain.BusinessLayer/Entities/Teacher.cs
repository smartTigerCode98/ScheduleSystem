namespace ScheduleSystem.Domain.BusinessLayer.Entities
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public ScienceDegree ScienceDegree { get; set; }
    }
}