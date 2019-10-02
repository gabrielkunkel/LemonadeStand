using System.Collections.Generic;

namespace LemonadeStand
{
  public class Day
  {
    public Weather weatherToday;
    public Weather weatherForceast;
    public List<Customer> customers;

 


    // todo: run through day
      // Determine weather conditions.
    // X CreateCustomers
    // todo: Determine sales for the day
    // cycle through list and judge whether purchase & how much
    // add money to wallet

    public Day()
    {
      CustomerFactory customerFactory = new CustomerFactory();
      this.customers = customerFactory.ProduceCustomers();
    }

    private void DetermineWeather()
    {
      WeatherProvider weatherFactory = new WeatherProvider();
      this.weatherToday = weatherFactory.getWeather();
      this.weatherForceast = weatherFactory.getWeather();
    }

  }


}