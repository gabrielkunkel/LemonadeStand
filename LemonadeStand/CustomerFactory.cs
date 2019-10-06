using System.Collections.Generic;

namespace LemonadeStand
{
  public class CustomerFactory
  {
    int numberOfCustomers;
    RandomGenerator randomGenerator = new RandomGenerator();
    WeatherProvider weatherProvider = new WeatherProvider();

    public CustomerFactory()
    {
      this.numberOfCustomers = 100;
    }

    public CustomerFactory(int numberOfCustomers)
    {
      this.numberOfCustomers = numberOfCustomers;
    }

    public List<ICustomer> ProduceCustomers()
    {
      List<ICustomer> customers = new List<ICustomer>();
      for (int i = 0; i < this.numberOfCustomers; i += 1)
      {
        customers.Add(ProduceRandomCustomer());
      }
      return customers;
    }

    // todo: convert this and test to private method
    public virtual Customer ProduceRandomCustomer()
    {
      return new Customer(GetLemonadeSpendableMoney(), GetListOfPreferredWeatherConditions());
    }

    private double GetLemonadeSpendableMoney()
    {
      return randomGenerator.GetRandomSpendingMoney(0.20);
    }
    private List<Weather> GetListOfPreferredWeatherConditions()
    {
      return randomGenerator.GetObjectOnProbabilityFromList(weatherProvider.weatherConditions);
    }


  }
}
