using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ScheduleSystem.DataApi.Base.Handlers;
using ScheduleSystem.DataApi.Contracts.Queries.UserByEmailAndPassword;
using ScheduleSystem.DataSource.Abstractions.Contracts.DBContext;
using ScheduleSystem.Domain.BusinessLogic.Abstractions.Contracs.Services;

namespace ScheduleSystem.DataApi.Handlers.Queries
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