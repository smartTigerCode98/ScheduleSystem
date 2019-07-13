using System.IO;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace ScheduleSystem.DataApi
{
	public static class Program
	{
		public static void Main(string[] args)
		{
			BuildWebHost(args).Run();
		}

		public static IWebHost BuildWebHost(string[] args)
		{
			return WebHost.CreateDefaultBuilder(args)
						  .UseStartup<Startup>()
						  .UseConfiguration(BuildConfiguration())
						  .Build();
		}

		private static IConfiguration BuildConfiguration()
		{
			return new ConfigurationBuilder()
				  .AddJsonFile("appSettings.json")
				  .Build();
		}
	}
}