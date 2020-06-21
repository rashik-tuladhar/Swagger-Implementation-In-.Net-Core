using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ImplementingSwagger.Controllers
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

        /// <summary>
        /// Sample Weather Forecast
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }


        /// <summary>
        /// Return Full Name From The Request
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        /// POST WeatherForeCast/FullName
        ///
        /// {
        ///
        ///         "FirstName":"Rashik",
        ///         "LastName":"Tuladhar"
        ///
        /// }
        /// </remarks>
        /// <param name="person"></param>
        /// <returns></returns>
        [Route("FullName")]
        [HttpPost]
        public string FullName(Person person)
        {
            return person.FirstName + " " + person.LastName;
        }
    }
}
