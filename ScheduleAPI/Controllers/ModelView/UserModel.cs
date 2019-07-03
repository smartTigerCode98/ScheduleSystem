using System.ComponentModel.DataAnnotations;
using ScheduleSystem.ScheduleAPI.Validators;

namespace ScheduleSystem.ScheduleAPI.Controllers.ModelView
{
    public class UserModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required]
        [UserPassword]
        public string Password { get; set; }
    }
}