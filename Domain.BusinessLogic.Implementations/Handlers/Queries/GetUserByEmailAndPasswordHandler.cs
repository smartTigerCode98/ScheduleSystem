using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ScheduleSystem.DataSource.Abstractions.Contracts.DBContext;
using ScheduleSystem.Domain.BusinessLogic.Abstractions.Base.Handlers;
using ScheduleSystem.Domain.BusinessLogic.Abstractions.Contracts.Services;
using ScheduleSystem.Domain.BusinessLogic.Abstractions.Contracts.Queries.UserByEmailAndPassword;

namespace ScheduleSystem.Domain.BusinessLogic.Implementations.Handlers.Queries
{
    public class GetUserByEmailAndPasswordHandler : QueryHandlerBase<UserByEmailAndPasswordQuery, UserByEmailAndPasswordResult>
    {
        private readonly IPasswordHasher _passwordHasher;

        public GetUserByEmailAndPasswordHandler(IDatabaseContext databaseContext, IPasswordHasher passwordHasher) : base(databaseContext)
        {
            _passwordHasher = passwordHasher;
        }

        public override Task<UserByEmailAndPasswordResult> Execute(UserByEmailAndPasswordQuery query, CancellationToken ctoken = default)
        {
            return DatabaseContext.Users.Where(user => user.Email == query.Email &&
                                                       _passwordHasher.Verify(user.PasswordHash, query.Password))
                .Select(user => new UserByEmailAndPasswordResult
                {
                    Id = user.Id,
                    Email = user.Email
                }).FirstOrDefaultAsync(ctoken);
        }
    }
}