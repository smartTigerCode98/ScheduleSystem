using System.Threading.Tasks;
using ScheduleSystem.DataSource.Abstractions.Contracts;
using ScheduleSystem.Domain.BusinessLogic.Abstractions.Contracs.Services;
using ScheduleSystem.Domain.BusinessLogic.Abstractions.Models.Services.Sign;
using ScheduleSystem.Domain.BusinessLogic.Implementations.Exceptions.Sign;
using ScheduleSystem.Domain.Entities;

namespace ScheduleSystem.Domain.BusinessLogic.Implementations.Services
{
	public sealed class SignService : ISignService
	{
		private readonly IUserRepository _userRepository;
		private readonly IPasswordHasher _passwordHasher;

		public SignService(IUserRepository userRepository, IPasswordHasher passwordHasher)
		{
			_userRepository = userRepository;
			_passwordHasher = passwordHasher;
		}

		public async Task SignUpAsync(SignUpModel signUpModel)
		{
			if (await _userRepository.UserWithEmailExists(signUpModel.Email))
			{
				throw new EmailAlreadyTakenException(signUpModel);
			}

			var user = new User
			{
				Email        = signUpModel.Email,
				PasswordHash = _passwordHasher.Hash(signUpModel.Password)
			};

			await _userRepository.CreateAsync(user);

			await _userRepository.SaveChangesAsync();
		}
	}
}