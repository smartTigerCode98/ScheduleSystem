using System.ComponentModel.DataAnnotations;
using ScheduleSystem.DataApi.Validators;

namespace ScheduleSystem.DataApi.Areas.Public.Sign.Models
{
	public sealed class SignUpViewModel
	{
		[Required]
		[EmailAddress]
		public string Email { get; set; }

		[Required]
		[UserPassword]
		public string Password { get; set; }
	}
}