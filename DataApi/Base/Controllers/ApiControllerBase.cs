using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Standalone.CQRS.Core.Abstractions.Contracts.Buses;
using Standalone.CQRS.Core.Abstractions.Contracts.Sources;

namespace ScheduleSystem.DataApi.Base.Controllers
{
    [ApiController]
    public abstract class ApiControllerBase : Controller
    {
        private readonly ICommonBus _commonBus;

        protected ApiControllerBase(ICommonBus commonBus)
        {
            _commonBus = commonBus;
        }

        protected Task Handle<TCommand>(TCommand command, CancellationToken ctoken = default)
            where TCommand : ICommand
        {
            return _commonBus.Handle(command, ctoken);
        }

        protected Task<TResult> Execute<TQuery, TResult>(TQuery query, CancellationToken ctoken = default)
            where TQuery : IQuery<TResult>
        {
            return _commonBus.Execute<TQuery, TResult>(query, ctoken);
        }
    }
}