namespace ScheduleSystem.ScheduleAPI.BusinessLogic.Entities
{
    public class Discipline
    {
        public  int Id { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }

        public Discipline(string name, int credits)
        {
            Name = name;
            Credits = credits;
        }
    }
}