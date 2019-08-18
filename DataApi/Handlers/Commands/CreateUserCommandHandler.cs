using System;
using System.Threading;
using System.Threading.Tasks;
using ScheduleSystem.DataApi.Base.Handlers;
using ScheduleSystem.DataApi.Contracts.Commands;
using ScheduleSystem.DataSource.Abstractions.Contracts.DBContext;
using ScheduleSystem.Domain.BusinessLogic.Abstractions.Contracs.Services;
using ScheduleSystem.Domain.Entities;
using Standalone.CQRS.Core.Abstractions.Contracts.Buses;

namespace ScheduleSystem.DataApi.Handlers.Commands
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