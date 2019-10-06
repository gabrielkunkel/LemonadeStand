using System;
using System.Collections.Generic;

namespace LemonadeStand
{
  public class Customer : ICustomer
  {
    public double lemonadeSpendableMoney { get; set; }
    public List<Weather> preferredWeatherConditions { get; set; }

    public Customer()
    {
      this.preferredWeatherConditions = new List<Weather>();
      this.lemonadeSpendableMoney = 0.50;
      this.preferredWeatherConditions.Add(new Weather());
    }

    public Customer(double lemonadeSpendableMoney)
    {
      this.preferredWeatherConditions = new List<Weather>();
      this.lemonadeSpendableMoney = lemonadeSpendableMoney;
      this.preferredWeatherConditions.Add(new Weather());
    }

    public Customer(double lemonadeSpendableMoney, List<Weather> preferredWeatherConditions)
    {
      this.preferredWeatherConditions = new List<Weather>();
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