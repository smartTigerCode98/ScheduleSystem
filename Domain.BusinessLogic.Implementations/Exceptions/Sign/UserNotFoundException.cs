using ScheduleSystem.Domain.BusinessLogic.Abstractions.Models.Services.Sign;
using ScheduleSytem.Shared.Base;

namespace ScheduleSystem.Domain.BusinessLogic.Implementations.Exceptions.Sign
{
    public class UserNotFoundException : ScheduleSystemApplicationExceptionBase
    {
        public const string ErrorMessage = "User not found.";
        
        public SignUpModel Model { get; }
        
        public UserNotFoundException(SignUpModel model) : base(ErrorMessage)
        {
            Model = model;
        }
    }
}