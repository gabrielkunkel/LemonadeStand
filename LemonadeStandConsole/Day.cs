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
    // todo: write tests for DetermineTodaySales on if there is/isn't enough inventory
    // todo: write test for inventory decreases based on recipe
    public double DetermineTodaySales(Stand stand)
    {
      int cupsToBuyTotal = 0;
      foreach (var customer in customers)
      {

        int thisCustomerWillBuy = customer.HowManyCupsWillCustomerPurchase(stand.recipe.price);

        while (!stand.inventory.IsEnoughInventory(stand.recipe, thisCustomerWillBuy) && thisCustomerWillBuy > 0)
        {
          thisCustomerWillBuy -= 1;
        }

        if (stand.inventory.IsEnoughInventory(stand.recipe))
        {
          if (CheckWeatherConditionsContained(customer.preferredWeatherConditions))
          { 
            stand.inventory.ReduceInventoryByCurrentRecipe(thisCustomerWillBuy, stand.recipe);
            cupsToBuyTotal += thisCustomerWillBuy;
          }
        }
        else
        {
          uIProvider.SoldOutOfInventory(stand);
          break;
        }
      }

      uIProvider.ReportTotalCupsSold(cupsToBuyTotal);

      return cupsToBuyTotal * stand.recipe.price;
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