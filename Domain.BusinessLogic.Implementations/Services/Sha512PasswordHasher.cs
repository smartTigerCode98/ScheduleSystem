using System;
using System.Security.Cryptography;
using System.Text;
using ScheduleSystem.Domain.BusinessLogic.Abstractions.Contracs.Services;
using ScheduleSytem.Shared.Exceptions;

namespace ScheduleSystem.Domain.BusinessLogic.Implementations.Services
{
	internal sealed class Sha512PasswordHasher : IPasswordHasher
	{
		private readonly SHA512 _sha512;
		
		public Sha512PasswordHasher(SHA512 sha512)
		{
			_sha512 = sha512;
		}

		public string Hash(string password)
		{
			if (String.IsNullOrWhiteSpace(password))
			{
				throw new InvalidArgumentException<string>(nameof(password), password);
			}

			var hashBytes = _sha512.ComputeHash(Encoding.UTF8.GetBytes(password));

			return Encoding.UTF8.GetString(hashBytes);
		}

		public bool Verify(string passwordHash, string givenPassword)
		{
			if (String.IsNullOrWhiteSpace(passwordHash))
			{
				throw new InvalidArgumentException<string>(nameof(passwordHash), passwordHash);
			}

			return passwordHash == Hash(givenPassword);
		}
	}
}