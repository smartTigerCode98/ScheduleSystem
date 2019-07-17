using ScheduleSystem.Domain.BusinessLogic.Abstractions.Models.Services.Sign;
using ScheduleSytem.Shared.Base;

namespace ScheduleSystem.Domain.BusinessLogic.Implementations.Exceptions.Sign
{
	public sealed class EmailAlreadyTakenException : ScheduleSystemUserExceptionBase
	{
		public const string ErrorMessage = "Email already taken."; 
		
		public EmailAlreadyTakenException(SignUpModel data) : base(data, ErrorMessage) { }
	}
}