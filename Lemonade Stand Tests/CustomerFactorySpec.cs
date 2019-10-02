using LemonadeStand;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;

namespace Lemonade_Stand_Tests
{
  [TestClass]
  public class CustomerFactorySpec
  {
    [TestMethod]
    public void ProduceCustomers_ReturnAList()
    {
      // Arrange
      Customer theCustomer = new Customer();

      Mock<CustomerFactory> mockCustomerFactory = new Mock<CustomerFactory>();
      mockCustomerFactory.Setup(mf => mf.ProduceRandomCustomer()).Returns(() => theCustomer);

      // Act
      List<Customer> result = mockCustomerFactory.Object.ProduceCustomers();

      // Assert
      Assert.AreEqual(100, result.Count);
      Assert.AreEqual(result[0].lemonadeSpendableMoney, 0.50);
      Assert.AreEqual(result[0].preferredWeatherConditions[0], "all");
    }
  }
}
