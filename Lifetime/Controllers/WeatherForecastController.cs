using Microsoft.AspNetCore.Mvc;

namespace Lifetime.Controllers
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
        private readonly ITransaction _transaction;
        private readonly IAnotherService _anotherService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, ITransaction transaction, IAnotherService anotherService)
        {
            _logger = logger;
            _transaction = transaction;
            _anotherService = anotherService;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public string Get()
        {
           Guid value1 = _transaction.Guid;
           Guid value2 = _anotherService.GetId();

           return value1 + " " + value2;
        }
    }
}
