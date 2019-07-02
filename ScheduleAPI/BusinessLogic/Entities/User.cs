namespace ScheduleSystem.ScheduleAPI.BusinessLogic.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; }
        public string PasswordHash { get; }
    }
}