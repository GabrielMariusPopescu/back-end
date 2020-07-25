using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace LoggingDemo.Pages
{
		public class IndexModel : PageModel
		{
			////This is the standard way of capturing the category
				//public IndexModel(ILogger<IndexModel> logger)
				//{
				//		this.logger = logger;
				//}
				
				public IndexModel(ILoggerFactory factory)
				{
					logger = factory.CreateLogger("DemoCategory");
				}

				public void OnGet()
				{
						//Logging levels
						logger.LogTrace("{time} - This is a trace log - many details and some application secrets", DateTime.UtcNow);
						logger.LogDebug("{time} - This is a debug log - still have some heavy debug information", DateTime.UtcNow);
						logger.LogInformation("{time} - This is an informational log - flow of how your application is being used", DateTime.UtcNow);
						logger.LogWarning("{time} - This is a warning log - you throw an exception but you caught it", DateTime.UtcNow);
						logger.LogError("{time} - This is an error log - part of your application crashed", DateTime.UtcNow);
						logger.LogCritical("{time} - This is a critical log - the application crashed, the whole thing is down", DateTime.UtcNow);

						////Advanced logging messages
						//logger.LogError("The server went down temporarily at {time}", DateTime.UtcNow);
						//try
						//{
						//		throw new Exception("You forgot to catch me");
						//}
						//catch (Exception exception)
						//{
						//	logger.LogCritical(exception, "There was a bad exception at {time}", DateTime.UtcNow);
						//}


				}

				//

				private readonly ILogger logger;
		}

		public class LoggingId
		{
				public const int DEMO_CODE = 1001;
		}
}