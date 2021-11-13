using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCorePocs.API.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class WeatherForecastController : ControllerBase
	{
		private static readonly string[] Summaries = new[]
		{
			"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
		};

		private readonly ILogger<WeatherForecastController> _logger;

		public WeatherForecastController(ILogger<WeatherForecastController> logger)
		{
			_logger = logger;
		}

		[HttpGet]
		public IEnumerable<WeatherForecast> Get()
		{
			_logger.LogInformation("Executing WeatherForecast action result");
			//_logger.LogInformation("Module: {Module}, Class: {Class}, Mehotd: {Method} Information data: ", "Weather" ,typeof(WeatherForecastController), typeof(WeatherForecastController));
			_logger.LogDebug("Debug WeatherForecast action");
			_logger.LogWarning("Warning on WeatherForecast");
			_logger.LogTrace("Trace data on WeatherForecast: {value}", 1987);
			_logger.LogError("Error on WeatherForecast; something fails");
			_logger.LogCritical("Help in WeatherForecast hurry up");

			var rng = new Random();
			return Enumerable.Range(1, 5).Select(index => new WeatherForecast
			{
				Date = DateTime.Now.AddDays(index),
				TemperatureC = rng.Next(-20, 55),
				Summary = Summaries[rng.Next(Summaries.Length)]
			})
			.ToArray();
		}
	}
}
