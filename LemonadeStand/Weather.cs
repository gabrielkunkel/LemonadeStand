using System.Collections.Generic;

namespace LemonadeStand
{
  public class Weather
  {
    public string condition;
    public double temperature;
    public double probOfWeatherEnjoyment;
    // todo: add probablePick

    public Weather()
    {
      this.condition = "clear"; // api: "Main"
      this.temperature = 72.8;
      this.probOfWeatherEnjoyment = .50;
    }

    public Weather(string condition, double temperature, double probOfWeatherEnjoyment)
    {
      this.condition = condition; // api: "Main"
      this.temperature = temperature;
      this.probOfWeatherEnjoyment = probOfWeatherEnjoyment;

    }


  }

}