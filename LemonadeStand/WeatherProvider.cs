using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
  class WeatherProvider
  {
    public List<Weather> weatherConditions = new List<Weather>();

    public WeatherProvider()
    {
      BuildWeatherList();
    }

    public Weather GetWeather()
    {
      RandomGenerator randomGenerator = new RandomGenerator();
      return randomGenerator.GetRandomListMember(weatherConditions);
    }

    private void BuildWeatherList()
    {
      weatherConditions.Add(new Weather("Thunderstorm", 52.7, 0.06));
      weatherConditions.Add(new Weather("Drizzle", 56.3, 0.12));
      weatherConditions.Add(new Weather("Rain", 57.2, 0.10));
      weatherConditions.Add(new Weather("Snow", 43.9, 0.02));
      weatherConditions.Add(new Weather("Clear", 70.3, 0.70));
      weatherConditions.Add(new Weather("Clouds", 62.4, 0.24));
    }

  }
}
