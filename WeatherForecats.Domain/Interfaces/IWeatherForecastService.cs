using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForecats.Domain.Models;

namespace WeatherForecats.Domain.Interfaces
{
    public interface IWeatherForecastService
    {
        List<WeatherForecast> ProcessTemperature();
    }
}
