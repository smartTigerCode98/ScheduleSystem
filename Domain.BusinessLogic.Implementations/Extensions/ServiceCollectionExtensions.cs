using System.Security.Cryptography;
using Microsoft.Extensions.DependencyInjection;
using ScheduleSystem.Domain.BusinessLogic.Abstractions.Contracs.Services;
using ScheduleSystem.Domain.BusinessLogic.Implementations.Services;

namespace ScheduleSystem.Domain.BusinessLogic.Implementations.Extensions
{
	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection AddDomainServices(this IServiceCollection services)
		{
			services.AddScoped<ISignService, SignService>()
					.AddScoped<IPasswordHasher, Sha512PasswordHasher>();

			services.AddSingleton<SHA512, SHA512Managed>();

			return services;
		}
	}
}