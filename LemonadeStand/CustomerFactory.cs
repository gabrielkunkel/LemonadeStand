using System.Collections.Generic;

namespace LemonadeStand
{
  public class CustomerFactory
  {
    readonly int numberOfCustomers = 100; // todo: make numberOfCustomers change
    RandomGenerator randomGenerator = new RandomGenerator();
    WeatherProvider weatherProvider = new WeatherProvider();

    public CustomerFactory()
    {
 
    }

    public List<Customer> ProduceCustomers()
    {
      List<Customer> customers = new List<Customer>();
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
