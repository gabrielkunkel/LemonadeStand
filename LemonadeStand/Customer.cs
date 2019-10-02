using System;
using System.Collections.Generic;

namespace LemonadeStand
{
  public class Customer
  {
    public double lemonadeSpendableMoney;
    public List<Weather> preferredWeatherConditions = new List<Weather>();

    public Customer()
    {
      this.lemonadeSpendableMoney = 0.50;
      this.preferredWeatherConditions.Add(new Weather("clear", 72.8, 0.50));
    }

    public Customer(double lemonadeSpendableMoney)
    {
      this.lemonadeSpendableMoney = lemonadeSpendableMoney;
      this.preferredWeatherConditions.Add(new Weather());
    }

    public Customer(double lemonadeSpendableMoney, List<Weather> preferredWeatherConditions)
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