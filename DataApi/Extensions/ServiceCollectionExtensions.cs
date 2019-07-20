using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using Serilog.Events;

namespace ScheduleSystem.DataApi.Extensions
{
	internal static class ServiceCollectionExtensions
	{
		private const string LogFormat = "{Timestamp} [{Level}] | {Message} {NewLine} {Exception} {NewLine}";

		public static IServiceCollection AddSerilog(this IServiceCollection services)
		{
			services.AddSingleton<ILogger>(provider =>
			{
				var appConfiguration = provider.GetRequiredService<IConfiguration>();

				var loggerConfiguration = CreateConfiguration(appConfiguration);

				return loggerConfiguration.CreateLogger();
			});

			return services;
		}

		private static LoggerConfiguration CreateConfiguration(IConfiguration configuration)
		{
			var outputPath = configuration["Logging:File:Path"];

			var loggerConfiguration = new LoggerConfiguration().WriteTo.File(outputPath,LogEventLevel.Information,
																			 LogFormat)
															   .WriteTo.Console(LogEventLevel.Information, LogFormat);

			return loggerConfiguration;
		}
	}
}