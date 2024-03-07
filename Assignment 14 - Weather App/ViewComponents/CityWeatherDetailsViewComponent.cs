using Microsoft.AspNetCore.Mvc;
using SharedModels;

namespace Assignment_14___Weather_App.ViewComponents
{
    public class CityWeatherDetailsViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(CityWeather weather, bool isDetailed)
        {
            ViewData["Detailed"] = isDetailed;
            return View(weather); 
        }
    }
}
