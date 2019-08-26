using Standalone.CQRS.Core.Abstractions.Contracts.Sources;

namespace ScheduleSystem.Domain.BusinessLogic.Abstractions.Contracts.Queries.UserByEmailAndPassword
{
    public class UserByEmailAndPasswordQuery : IQuery<UserByEmailAndPasswordResult>
    {
        public string Email { get; set; }
        
        public string Password { get; set;}
    }
}