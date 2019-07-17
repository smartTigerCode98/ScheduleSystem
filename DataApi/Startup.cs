using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using ScheduleSystem.DataApi.Filters;
using ScheduleSystem.DataSource.Abstractions.Contracts;
using ScheduleSystem.DataSource.Implementation;
using ScheduleSystem.DataSource.Implementation.Extensions;
using ScheduleSystem.DataSource.Implementation.Repositories;
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
			services.AddDataSource(Configuration.GetConnectionString("Default"));

			services.AddDomainServices();

			services.AddMvc(options => { options.Filters.Add<ExceptionHandlingFilter>(); })
					.SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
		}

		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			app.UseMvc();
		}
	}
}