namespace ScheduleSystem.Domain.Entities
{
	public class Discipline
	{
		public int    Id      { get; set; }
		public string Name    { get; set; }
		public int Credits { get; set; }
		
		public Discipline(int id, string name, int credits)
		{
			Id = id;
			Name = name;
			Credits = credits;
		}
	}
}