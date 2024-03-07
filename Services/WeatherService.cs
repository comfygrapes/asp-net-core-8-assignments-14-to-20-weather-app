using ServiceContracts;
using SharedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class WeatherService : IWeatherService
    {
        private List<CityWeather> _cityWeatherDetails = new() {
            new CityWeather()
            {
                CityUniqueCode = "LDN", CityName = "London", DateAndTime = Convert.ToDateTime("2030-01-01 8:00"),  TemperatureFahrenheit = 33,
            },
            new CityWeather()
            {
                CityUniqueCode = "NYC", CityName = "New York", DateAndTime = Convert.ToDateTime("2030-01-01 3:00"),  TemperatureFahrenheit = 60,
            },
            new CityWeather()
            {
                CityUniqueCode = "PAR", CityName = "Paris", DateAndTime = Convert.ToDateTime("2030-01-01 9:00"),  TemperatureFahrenheit = 82,
            }
        };

        public CityWeather? GetWeatherByCityCode(string cityCode)
        {
            return _cityWeatherDetails.FirstOrDefault(cityWeather => cityWeather.CityUniqueCode == cityCode);
        }

        public List<CityWeather> GetWeatherDetails()
        {
            return _cityWeatherDetails;
        }
    }
}
