namespace ScheduleSystem.ScheduleAPI.BusinessLogic.Entities
{
    public class ScienceDegree
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ScienceDegree(string name)
        {
            Name = name;
        }
    }
}