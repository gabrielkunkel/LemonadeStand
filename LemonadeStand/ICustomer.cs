using System.Collections.Generic;

namespace LemonadeStand
{
  public interface ICustomer
  {
    double lemonadeSpendableMoney { get; set; }
    List<Weather> preferredWeatherConditions { get; set; }

    int HowManyCupsWillCustomerPurchase(double lemonadeCupPrice);
    bool WillPurchase(double lemonadeCupPrice);
  }
}