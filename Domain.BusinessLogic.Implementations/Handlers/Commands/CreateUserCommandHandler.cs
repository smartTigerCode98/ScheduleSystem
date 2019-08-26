using System.Threading;
using System.Threading.Tasks;
using ScheduleSystem.DataSource.Abstractions.Contracts.DBContext;
using ScheduleSystem.Domain.BusinessLogic.Abstractions.Base.Handlers;
using ScheduleSystem.Domain.BusinessLogic.Abstractions.Contracts.Services;
using ScheduleSystem.Domain.BusinessLogic.Abstractions.Contracts.Commands;
using ScheduleSystem.Domain.Entities;
using Standalone.CQRS.Core.Abstractions.Contracts.Buses;
using System;

namespace ScheduleSystem.Domain.BusinessLogic.Implementations.Handlers.Commands
{
    public class CreateUserCommandHandler : CommandHandlerBase<CreateUserCommand>
    {
        private readonly IPasswordHasher _passwordHasher;
        
        public CreateUserCommandHandler(IDatabaseContext databaseContext, IEventBus eventBus, IPasswordHasher passwordHasher) : base(databaseContext, eventBus)
        {
            _passwordHasher = passwordHasher;
        }

        public override async Task Execute(CreateUserCommand command, CancellationToken ctoken = default)
        { 
           

            var user = new User
            {
                Email = command.Email,
                PasswordHash = _passwordHasher.Hash(command.Password)
            };
            
            DatabaseContext.Users.Add(user);

            await DatabaseContext.SaveChangesAsync(ctoken);
        }
    }
}