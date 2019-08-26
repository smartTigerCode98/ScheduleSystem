using System.Security.Cryptography;
using Microsoft.Extensions.DependencyInjection;
using ScheduleSystem.Domain.BusinessLogic.Abstractions.Contracts.Services;
using ScheduleSystem.Domain.BusinessLogic.Implementations.Services;
using Swashbuckle.AspNetCore.Swagger;


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

		public static IServiceCollection AddSwagger(this IServiceCollection services)
		{
			services.AddSwaggerGen(c => { c.SwaggerDoc("v1", new Info {Title = "Schedule system", Version = "v1"}); });
			return services;
		}
	}
}