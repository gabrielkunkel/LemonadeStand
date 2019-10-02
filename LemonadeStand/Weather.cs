using System.Collections.Generic;

namespace LemonadeStand
{
  public class Weather
  {
    public string condition;
    public double temperature;
    public double probOfWeatherEnjoyment;

    public Weather()
    {
      this.condition = "clear"; // api: "Main"
      this.temperature = 60.0;
      this.probOfWeatherEnjoyment = .40;
    }

    public Weather(string condition, double temperature, double probOfWeatherEnjoyment)
    {
      this.condition = condition; // api: "Main"
      this.temperature = temperature;
      this.probOfWeatherEnjoyment = probOfWeatherEnjoyment;

    }


  }

}