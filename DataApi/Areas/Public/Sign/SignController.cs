using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ScheduleSystem.DataApi.Areas.Public.Sign.Models;
using ScheduleSystem.DataApi.Base.Controllers;
using ScheduleSystem.Domain.BusinessLogic.Abstractions.Contracts.Commands;
using ScheduleSystem.Domain.BusinessLogic.Abstractions.Contracts.Queries.UserByEmailAndPassword;
using Standalone.CQRS.Core.Abstractions.Contracts.Buses;

namespace ScheduleSystem.DataApi.Areas.Public.Sign
{
	[Route("api/public/sign")]
	public sealed class SignController : ApiControllerBase
	{
		public SignController(ICommonBus commonBus) : base(commonBus) {}

		[HttpPost("up")]
		public Task Up([FromBody] SignUpViewModel model)
		{
			return Handle(new CreateUserCommand
			{
				Email = model.Email,
				Password = model.Password
			});
		}
		
		[HttpPost("in")]
		public Task<UserByEmailAndPasswordResult> In([FromBody] SignUpViewModel model)
		{
			var query = new UserByEmailAndPasswordQuery
			{
				Email = model.Email, Password = model.Password
				
			};

			return Execute<UserByEmailAndPasswordQuery, UserByEmailAndPasswordResult>(query);
		}
		

		
	}
}