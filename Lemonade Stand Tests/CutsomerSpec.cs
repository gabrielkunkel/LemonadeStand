using LemonadeStand;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Lemonade_Stand_Tests
{
  [TestClass]
  public class CutsomerSpec
  {
    [TestMethod]
    public void WillPurchase_HasEnoughMoney_SetByDefault()
    {
      Customer myCustomer = new Customer();
      var result = myCustomer.WillPurchase(0.25);

      Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void WillPurchase_HasTooLittleMoney_SetByClassConstructor()
    {
      var myList = new List<string>() { "cloudy", "sunny", "hot" };

      Customer myCustomer = new Customer(0.10, myList);
      var result = myCustomer.WillPurchase(0.25);

      Assert.AreEqual(false, result);
    }

    [TestMethod]
    public void WillPurchase_HasEnoughMoney_SetByClassConstructor()
    {
      var myList = new List<string>() { "cloudy", "sunny", "hot" };

      Customer myCustomer = new Customer(0.25, myList);
      var result = myCustomer.WillPurchase(0.25);

      Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void HowManyCupsWillCustomerPurchase_HasTooLittleMoney_SetByClass()
    {
      var myList = new List<string>() { "cloudy", "sunny", "hot" };

      Customer myCustomer = new Customer(0.10, myList);
      var result = myCustomer.HowManyCupsWillCustomerPurchase(0.25);

      Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void HowManyCupsWillCustomerPurchase_HasEnoughMoneyForOne_SetByClass()
    {
      var myList = new List<string>() { "cloudy", "sunny", "hot" };

      Customer myCustomer = new Customer(0.48, myList);
      var result = myCustomer.HowManyCupsWillCustomerPurchase(0.25);

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void HowManyCupsWillCustomerPurchase_HasEnoughMoneyForTwo_SetByClass()
    {
      var myList = new List<string>() { "cloudy", "sunny", "hot" };

      Customer myCustomer = new Customer(0.51, myList);
      var result = myCustomer.HowManyCupsWillCustomerPurchase(0.25);

      Assert.AreEqual(2, result);
    }

  }
}
