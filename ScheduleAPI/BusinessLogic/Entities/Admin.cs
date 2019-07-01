namespace ScheduleSystem.ScheduleAPI.BusinessLogic.Entities
{
    public class Admin
    {
        public int Id { get; set; }
        public string Email { get; }
        public string PasswordHash { get; }

        public Admin(string email, string passwordHash)
        {
            Email = email;
            PasswordHash = passwordHash;
        }
    }
}