using System.Threading;
using System.Threading.Tasks;
using ScheduleSystem.DataSource.Abstractions.Contracts.DBContext;
using Standalone.CQRS.Core.Abstractions.Contracts.Buses;
using Standalone.CQRS.Core.Abstractions.Contracts.Handlers;
using Standalone.CQRS.Core.Abstractions.Contracts.Sources;

namespace ScheduleSystem.Domain.BusinessLogic.Abstractions.Base.Handlers
{
    public abstract class CommandHandlerBase<TCommand> : ICommandHandler<TCommand> where TCommand : ICommand
    {
        protected IDatabaseContext DatabaseContext { get; }
        protected IEventBus EventBus { get; }

        protected CommandHandlerBase(IDatabaseContext databaseContext, IEventBus eventBus)
        {
            DatabaseContext = databaseContext;
            EventBus = eventBus;
        }

        public abstract Task Execute(TCommand command, CancellationToken ctoken = default);
    }
}