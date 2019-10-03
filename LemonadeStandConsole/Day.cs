using System.Collections.Generic;
using LemonadeStand;

namespace LemonadeStandConsole
{
  public class Day
  {
    public Weather weatherToday;
    public Weather weatherForecast;
    public List<Customer> customers;
    private UIProvider uIProvider;

    public Day(UIProvider uIProvider)
    {
      this.uIProvider = uIProvider;
      DetermineWeather();
      PopulateCustomersList();
    }

    public void Run(Player player)
    {
      uIProvider.GetInventoryUpdate(player);
      double todaySales = DetermineTodaySales(player.stand);
      player.stand.register.Income(todaySales);
    }

    // todo modify recipe


    public double DetermineTodaySales(Stand stand)
    {
      int cupsToBuy = 0;
      foreach (var item in customers)
      {
        // todo: write test inventory check
        if (stand.inventory.IsEnoughInventory(stand.recipe))
        {
          if (CheckWeatherConditionsContained(item.preferredWeatherConditions))
          { 
            cupsToBuy += item.HowManyCupsWillCustomerPurchase(stand.recipe.price);
          }
        }
      }

      return cupsToBuy*stand.recipe.price;
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