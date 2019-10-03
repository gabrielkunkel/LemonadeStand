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

    // todo: Day.Run method

    public double DetermineTodaySales(double costOfLemonadeCup)
    {
      int cupsToBuy = 0;
      foreach (var item in customers)
      {
        
        if (CheckWeatherConditionsContained(item.preferredWeatherConditions))
        {
          // todo: break the loop if we run out of ingredients before
          cupsToBuy += item.HowManyCupsWillCustomerPurchase(costOfLemonadeCup);
        }

      }

      return cupsToBuy*costOfLemonadeCup;
    }

    public bool CheckWeatherConditionsContained(List<Weather> weatherConditions)
    {
      foreach (var item in weatherConditions)
      {
        if (item.condition == this.weatherToday.condition)
        {
          return true;
        }
      }

      return false;
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