using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace HotelListing
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Log.Logger = new LoggerConfiguration()
				.WriteTo.File(
					path: "d:\\DEVELOPMENT\\Projects\\HotelListing\\HotelListing\\logs\\log-.txt",
					outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}",
					rollingInterval: RollingInterval.Day,
					restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Information
				).CreateLogger();

			try
			{
				Log.Information("Application is Starting");
				CreateHostBuilder(args).Build().Run();
			}
			catch (System.Exception e)  
			{
				Log.Fatal(e, "Application Failed to Start");
			}
			finally
			{
				Log.CloseAndFlush();
			}
		}

		public static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder(args)
				.UseSerilog()
				.ConfigureWebHostDefaults(webBuilder =>
				{
					webBuilder.UseStartup<Startup>();
				});
	}
}
