using System.Collections.Generic;

namespace LemonadeStand
{
  public class Day
  {
    public Weather weather;
    public List<Customer> customers;

    // todo: run through day
    // Determine weather conditions.
    // CreateCustomers
    // Determine how many cups of lemonade all the customers buy
    // 

    public Day()
    {
      CustomerFactory customerFactory = new CustomerFactory();
      this.customers = customerFactory.ProduceCustomers();
    }

  }


}