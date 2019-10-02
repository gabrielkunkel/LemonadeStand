using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LemonadeStand;
using System.Collections.Generic;

namespace Lemonade_Stand_Tests
{
  [TestClass]
  public class DaySpec
  {
    [TestMethod]
    public void DetermineTodaySales_AllCustomersSame()
    {

      Day today = new Day();
      today.weatherToday = new Weather();
      today.customers = new List<Customer>();
      today.customers.Add(new Customer());
      today.customers.Add(new Customer());
      today.customers.Add(new Customer());
      today.customers.Add(new Customer());
      today.customers.Add(new Customer());

      // Act
      double result = today.DetermineTodaySales(0.25);


      // Assert
      Assert.AreEqual(2.50, result);
    }

    [TestMethod]
    public void DetermineTodaySales_CustomersHaveUnpreferredWeather()
    {

      Day today = new Day();
      today.weatherToday = new Weather("rainstorms", 60, 1);
      today.customers = new List<Customer>();
      today.customers.Add(new Customer());
      today.customers.Add(new Customer());
      today.customers.Add(new Customer());
      today.customers.Add(new Customer());
      today.customers.Add(new Customer());

      // Act
      double result = today.DetermineTodaySales(0.25);


      // Assert
      Assert.AreEqual(0, result);
    }

    // todo: add test for varying customers

  }
}
