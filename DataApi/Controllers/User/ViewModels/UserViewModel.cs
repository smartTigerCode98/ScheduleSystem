using System.ComponentModel.DataAnnotations;
using ScheduleSystem.DataApi.Validators;

namespace ScheduleSystem.DataApi.Controllers.User.ViewModels
{
    public class UserViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required]
        [UserPassword]
        public string Password { get; set; }
    }
}