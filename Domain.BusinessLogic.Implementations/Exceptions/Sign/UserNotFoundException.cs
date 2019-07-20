using ScheduleSystem.Domain.BusinessLogic.Abstractions.Models.Services.Sign;
using ScheduleSytem.Shared.Base;

namespace ScheduleSystem.Domain.BusinessLogic.Implementations.Exceptions.Sign
{
    public class UserNotFoundException : ScheduleSystemApplicationExceptionBase
    {
        public const string ErrorMessage = "User not found.";
        
        public UserNotFoundException(SignUpModel data) : base(data, ErrorMessage) { }
    }
}