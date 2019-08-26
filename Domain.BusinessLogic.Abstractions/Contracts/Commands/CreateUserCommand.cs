using Standalone.CQRS.Core.Abstractions.Contracts.Sources;

namespace ScheduleSystem.Domain.BusinessLogic.Abstractions.Contracts.Commands
{
    public class CreateUserCommand : ICommand
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}