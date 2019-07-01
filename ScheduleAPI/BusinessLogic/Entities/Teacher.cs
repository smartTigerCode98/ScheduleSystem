namespace ScheduleSystem.ScheduleAPI.BusinessLogic.Entities
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public ScienceDegree ScienceDegree { get; set; }

        public Teacher(string name, string surname, ScienceDegree scienceDegree)
        {
            Name = name;
            Surname = surname;
            ScienceDegree = scienceDegree;
        }
    }
}