using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
  public class CustomerFactory
  {
    readonly int numberOfCustomers = 100; // todo: make numberOfCustomers change
    Dictionary<string, double> probabilityOfWeatherEnjoyment = new Dictionary<string, double>();
    RandomGenerator randomGenerator = new RandomGenerator();

    public CustomerFactory()
    {
      probabilityOfWeatherEnjoyment.Add("warm", 0.48);
      probabilityOfWeatherEnjoyment.Add("hot", 0.58);
      probabilityOfWeatherEnjoyment.Add("rain", 0.10);
      probabilityOfWeatherEnjoyment.Add("cold", 0.02);
      probabilityOfWeatherEnjoyment.Add("sunny", 0.67);
      probabilityOfWeatherEnjoyment.Add("cloudy", 0.18);
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
    private List<string> GetListOfPreferredWeatherConditions()
    {
      return randomGenerator.GetDictionaryStringOnProbability(probabilityOfWeatherEnjoyment);
    }
 

  }
}
