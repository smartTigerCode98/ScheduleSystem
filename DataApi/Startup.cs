using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ScheduleSystem.DataApi.Extensions;
using ScheduleSystem.DataApi.Filters;
using ScheduleSystem.DataApi.Filters.Logging;
using ScheduleSystem.DataSource.Implementation.Extensions;
using ScheduleSystem.Domain.BusinessLogic.Implementations.Extensions;


namespace ScheduleSystem.DataApi
{
	public class Startup
	{
		public IConfiguration Configuration { get; }

		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public void ConfigureServices(IServiceCollection services)
		{
			services.AddSerilog();
			
			services.AddDataSource(Configuration.GetConnectionString("Default"));

			services.AddDomainServices();

			services.AddMvc(options =>
					 {
						 options.Filters.Add<ExceptionHandlingFilter>();
						 options.Filters.Add<ActionLoggingFilter>();
					 })
					.SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

			services.AddSwagger();


			services.AddCqrs();
			
			services.AddDatabaseContext();
		}

		public void Configure(IApplicationBuilder app)
		{
			app.UseMvc();
			
			app.UseSwagger();

			app.UseSwaggerUI(c =>
			{
				c.SwaggerEndpoint("/swagger/v1/swagger.json", "Schedule system");
			});

		}
	}
}