using System.Collections.Generic;

namespace LemonadeStand
{
  public class Weather
  {
    public string condition;
    public int temperature;
    public List<string> weatherConditions = new List<string>() { };
    public string predictedForecast;

  }
}