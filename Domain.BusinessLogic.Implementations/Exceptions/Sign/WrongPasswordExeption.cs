using ScheduleSystem.Domain.BusinessLogic.Abstractions.Models.Services.Sign;
using ScheduleSytem.Shared.Base;

namespace ScheduleSystem.Domain.BusinessLogic.Implementations.Exceptions.Sign
{
    public class WrongPasswordExeption : ScheduleSystemUserExceptionBase
    {
        private const string ErrorMessage = "Your password does not match";
        
        public WrongPasswordExeption(SignUpModel signUpModel) : base(signUpModel, ErrorMessage) {}
    }
}