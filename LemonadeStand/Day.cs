using System.Collections.Generic;

namespace LemonadeStand
{
  public class Day
  {
    public Weather weather;
    public List<Customer> customers;
    public List<string> weatherConditions = new List<string>(){"warm", "hot", "rain", "cold", "sunny", "cloudy"};
    // todo: Price of lemons?


    // todo: run through day
      // Determine weather conditions.
      // X CreateCustomers
      // Determine how many cups of lemonade all the customers buy
      // 

    public Day()
    {
      CustomerFactory customerFactory = new CustomerFactory();
      this.customers = customerFactory.ProduceCustomers();
    }

  }


}