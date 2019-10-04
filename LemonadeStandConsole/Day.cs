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
    private int dayNumber;

    public Day(UIProvider uIProvider, int dayNumber)
    {
      this.uIProvider = uIProvider;
      this.dayNumber = dayNumber;
      DetermineWeather();
      PopulateCustomersList();
    }

    public void Run(Player player)
    {
      uIProvider.StartDay(dayNumber, weatherToday, weatherForecast);
      uIProvider.GetInventoryUpdate(player.stand);
      uIProvider.GetRecipeUpdate(player.stand);
      double todaySales = DetermineTodaySales(player.stand);
      player.stand.register.collectDaySalesAndProfit(todaySales);
      player.stand.register.Income(todaySales);
      uIProvider.EndDay(player);
    }

    // todo: break up DetermineTodaySales if possible
    public double DetermineTodaySales(Stand stand)
    {
      int cupsToBuy = 0; // cupsToBuy is rising, even when there aren't sales
      foreach (var customer in customers)
      {
        // todo: write tests for DetermineTodaySales on if there is/isn't enough inventory
        // todo: write test for inventory decreases based on recipe
        if (stand.inventory.IsEnoughInventory(stand.recipe))
        {
          if (CheckWeatherConditionsContained(customer.preferredWeatherConditions))
          { 
            cupsToBuy += customer.HowManyCupsWillCustomerPurchase(stand.recipe.price);
          }
        }
        else
        {
          uIProvider.SoldOutOfInventory(stand);
          break;
        }
      }

      stand.inventory.ReduceInventoryByCurrentRecipe(cupsToBuy, stand.recipe);

      return cupsToBuy * stand.recipe.price;
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