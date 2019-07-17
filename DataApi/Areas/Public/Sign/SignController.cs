using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ScheduleSystem.DataApi.Areas.Public.Sign.Models;
using ScheduleSystem.DataApi.Base;
using ScheduleSystem.Domain.BusinessLogic.Abstractions.Contracs.Services;
using ScheduleSystem.Domain.BusinessLogic.Abstractions.Models.Services.Sign;

namespace ScheduleSystem.DataApi.Areas.Public.Sign
{
	[Route("api/public/sign")]
	public sealed class SignController : ApiControllerBase
	{
		private readonly ISignService _signService;

		public SignController(ISignService signService)
		{
			_signService = signService;
		}

		[HttpPost("up")]
		public async Task<IActionResult> Up([FromBody] SignUpViewModel model)
		{
			await _signService.SignUpAsync(new SignUpModel
			{
				Email    = model.Email,
				Password = null
			});

			return Ok();
		}
	}
}