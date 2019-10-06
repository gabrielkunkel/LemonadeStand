using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LemonadeStandConsole;
using LemonadeStand;
using System.Collections.Generic;

namespace Lemonade_Stand_Tests
{
  [TestClass]
  public class DaySpec
  {
    [TestMethod]
    public void DetermineTodaySales_AllCustomersSame_PlentyInventory()
    {
      UIProvider uIProvider = new UIProvider();
      Day today = new Day(uIProvider, 1);
      Stand defaultStand = new Stand();
      today.weatherToday = new Weather();
      defaultStand.inventory.AddToInventory(1000, 1000, 1000, 1000);
      today.customers = new List<ICustomer>();
      today.customers.Add(new Customer());
      today.customers.Add(new Customer());
      today.customers.Add(new Customer());
      today.customers.Add(new Customer());
      today.customers.Add(new Customer());

      // Act
      double result = today.DetermineTodaySales(defaultStand);


      // Assert
      Assert.AreEqual(2.50, result);
    }

    [TestMethod]
    public void DetermineTodaySales_CustomersHaveUnpreferredWeather()
    {

      UIProvider uIProvider = new UIProvider();
      Day today = new Day(uIProvider, 1);
      Stand defaultStand = new Stand();
      today.weatherToday = new Weather("rainstorms", 60, 1);
      today.customers = new List<ICustomer>();
      today.customers.Add(new Customer());
      today.customers.Add(new Customer());
      today.customers.Add(new Customer());
      today.customers.Add(new Customer());
      today.customers.Add(new Customer());

      // Act
      double result = today.DetermineTodaySales(defaultStand);


      // Assert
      Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void DetermineTodaySales_VaryingCustomers()
    {
      // Arrange Weather Lists
      List<Weather> weatherListFirstCustomer = new List<Weather>();
      weatherListFirstCustomer.Add(new Weather("slushy", 10, .80));
      weatherListFirstCustomer.Add(new Weather("slimey", 10, .80));
      weatherListFirstCustomer.Add(new Weather("gunky", 10, .80));

      List<Weather> weatherListSecondCustomer = new List<Weather>();
      weatherListSecondCustomer.Add(new Weather("slushy", 10, .80));
      weatherListSecondCustomer.Add(new Weather("mucky", 10, .80));
      weatherListSecondCustomer.Add(new Weather("slunky", 10, .80));

      List<Weather> weatherListThirdCustomer = new List<Weather>();
      weatherListThirdCustomer.Add(new Weather("slushy", 10, .80));
      weatherListThirdCustomer.Add(new Weather("doofy", 10, .80));
      weatherListThirdCustomer.Add(new Weather("funky", 10, .80));

      // Arrange Customers
      UIProvider uIProvider = new UIProvider();
      Day today = new Day(uIProvider, 1);
      Stand defaultStand = new Stand();
      defaultStand.inventory.AddToInventory(1000, 1000, 1000, 1000);
      defaultStand.recipe.price = 0.35;
      today.weatherToday = new Weather("slushy", 60, 1);
      today.customers = new List<ICustomer>();
      today.customers.Add(new Customer(0.50, weatherListFirstCustomer));
      today.customers.Add(new Customer(1.05, weatherListSecondCustomer));
      today.customers.Add(new Customer(0.40, weatherListThirdCustomer));
      today.customers.Add(new Customer(20.00));
      today.customers.Add(new Customer(20.00));

      // Act
      double result = today.DetermineTodaySales(defaultStand);


      // Assert
      Assert.AreEqual(1.75, result);
    }
  }
}
