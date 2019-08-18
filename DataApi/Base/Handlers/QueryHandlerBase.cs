using System.Threading;
using System.Threading.Tasks;
using ScheduleSystem.DataSource.Abstractions.Contracts.DBContext;
using Standalone.CQRS.Core.Abstractions.Contracts.Handlers;
using Standalone.CQRS.Core.Abstractions.Contracts.Sources;

namespace ScheduleSystem.DataApi.Base.Handlers
{
    public abstract class QueryHandlerBase<TQuery, TResult> : IQueryHandler<TQuery, TResult>
        where TQuery : IQuery<TResult>
    {
        protected IDatabaseContext DatabaseContext { get; }

        protected QueryHandlerBase(IDatabaseContext databaseContext)
        {
            DatabaseContext = databaseContext;
        }

        public abstract Task<TResult> Execute(TQuery query, CancellationToken ctoken = default);
    }
}