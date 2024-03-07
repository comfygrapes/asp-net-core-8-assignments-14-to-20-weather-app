using Microsoft.AspNetCore.Mvc;
using ServiceContracts;

namespace Assignment_14___Weather_App.Controllers
{
    public class CityWeatherController : Controller
    {
        private readonly IWeatherService _weatherService;

        public CityWeatherController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            ViewData["Title"] = "Weather";

            return View(_weatherService.GetWeatherDetails());
        }

        [HttpGet]
        [Route("weather/{cityCode?}")]
        public IActionResult DisplayWeather(string cityCode)
        {
            var cityWeather = _weatherService.GetWeatherByCityCode(cityCode);
            if (cityWeather == null)
            {
                return NotFound("City does not exist");
            }

            ViewData["Title"] = $"{cityWeather?.CityName} Weather";

            return View(cityWeather);
        }
    }
}
