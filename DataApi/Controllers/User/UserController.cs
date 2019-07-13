using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ScheduleSystem.DataApi.Base;
using ScheduleSystem.DataApi.Controllers.User.ViewModels;
using ScheduleSystem.DataSource.Abstractions.Contracts;

namespace ScheduleSystem.DataApi.Controllers.User
{
	[Route("users")]
	public class UserController : ApiControllerBase
	{
		private readonly IUserRepository _userRepository;

		public UserController(IUserRepository userRepository)
		{
			_userRepository = userRepository;
		}

		[HttpGet("{id}")]
		public Task<Domain.Entities.User> GetUser([FromRoute] int id)
		{
			return _userRepository.GetByIdAsync(id);
		}

		[HttpPost("login")]
		public IActionResult SignIn([FromBody] UserViewModel userViewModel)
		{
			return Ok(userViewModel);
		}

		[HttpPost("registration")]
		public async Task<IActionResult> SignUp([FromBody] UserViewModel userViewModel)
		{
			var user = new Domain.Entities.User
			{
				Id           = 322,
				Email        = userViewModel.Email,
				PasswordHash = userViewModel.Password
			};

			await _userRepository.CreateAsync(user);

			return Ok();
		}
	}
}