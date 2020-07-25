using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace LoggingDemo
{
		public class Program
		{
				public static void Main(string[] args)
				{
						var host = CreateHostBuilder(args).Build();
						var logger = host.Services.GetRequiredService<ILogger<Program>>();
						logger.LogInformation("The application has started at {time}", DateTime.UtcNow);
						host.Run();
				}

				//

				private static IHostBuilder CreateHostBuilder(string[] args)
				{
						return Host.CreateDefaultBuilder(args)
							.ConfigureLogging((context, builder) =>
							{
									builder.ClearProviders();
									builder.AddConfiguration(context.Configuration.GetSection("Logging"));
									builder.AddDebug();
									builder.AddConsole();
							})
							.ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
				}
		}
}