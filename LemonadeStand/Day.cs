using System.Collections.Generic;

namespace LemonadeStand
{
  public class Day
  {
    public Weather weatherToday;
    public Weather weatherForecast;
    public List<Customer> customers;

    // todo: Determine sales for the day
      // cycle through list and judge whether purchase & how much
      // add money to wallet

    public Day()
    { 
      DetermineWeather();
      PopulateCustomersList();
    }

    private void DetermineWeather()
    {
      WeatherProvider weatherProvider = new WeatherProvider();
      this.weatherToday = weatherProvider.GetWeather();
      this.weatherForecast = weatherProvider.GetWeather();
    }

    private void PopulateCustomersList()
    {
      CustomerFactory customerFactory = new CustomerFactory();
      this.customers = customerFactory.ProduceCustomers();
    }

  }


}