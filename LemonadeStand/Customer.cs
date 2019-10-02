using System;
using System.Collections.Generic;

namespace LemonadeStand
{
  public class Customer
  {
    public double lemonadeSpendableMoney;
    public List<string> preferredWeatherConditions = new List<string>();

    public Customer()
    {
      this.lemonadeSpendableMoney = 0.50;
      this.preferredWeatherConditions.Add("all");
    }

    public Customer(double lemonadeSpendableMoney, List<string> preferredWeatherConditions)
    {
      this.lemonadeSpendableMoney = lemonadeSpendableMoney;
      this.preferredWeatherConditions = preferredWeatherConditions;
    }

    public bool WillPurchase(double lemonadeCupPrice)
    {
      return lemonadeCupPrice <= lemonadeSpendableMoney;
    }

    public int HowManyCupsWillCustomerPurchase(double lemonadeCupPrice)
    {
      if (!WillPurchase(lemonadeCupPrice))
      {
        return 0;
      }
      else
      {
        double numberToRound = lemonadeSpendableMoney / lemonadeCupPrice;
        return Convert.ToInt32(Math.Floor(numberToRound));

      }
    }

  }
}