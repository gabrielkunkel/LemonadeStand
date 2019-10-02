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

    // todo: add in randomGenerator and pick which whether we're going to have based on probability
    public Weather GetWeather()
    {
      RandomGenerator randomGenerator = new RandomGenerator();
      return randomGenerator.GetRandomListMember(weatherConditions);
    }

    private void BuildWeatherList()
    {
      weatherConditions.Add(new Weather("Thunderstorm", 52.7, 0.01));
      weatherConditions.Add(new Weather("Drizzle", 56.3, 0.10));
      weatherConditions.Add(new Weather("Rain", 57.2, 0.05));
      weatherConditions.Add(new Weather("Snow", 43.9, 0.02));
      weatherConditions.Add(new Weather("Clear", 70.3, 0.01));
      weatherConditions.Add(new Weather("Clouds", 62.4, 0.01));
    }

  }
}
