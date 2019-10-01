using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LemonadeStand;
using Moq;
using System.Collections.Generic;

namespace Lemonade_Stand_Tests
{
  [TestClass]
  public class RandomGeneratorSpec
  {
    [TestMethod]
    public void GetRandomListMember_ListOfStrings()
    {
      // Arrange
      List<string> strings = new List<string> { "red", "yellow", "green" };
      string expected = "green";
      int numberGenerated = 2;

      Mock<Random> mockRandom = new Mock<Random>();
      mockRandom.Setup(rand => rand.Next(strings.Count)).Returns(() => numberGenerated);
      var subject = new RandomGenerator(mockRandom.Object);

      // Act
      string result = subject.GetRandomListMember(strings);

      // Assert
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void GetRandomMoney_Amount()
    {
      // Arrange
      double numberGenerated = 0.75829482;
      double startAmount = 0.25;
      double expected = 1.01;

      Mock<Random> mockRandom = new Mock<Random>();
      mockRandom.Setup(rand => rand.NextDouble()).Returns(() => numberGenerated);
      var subject = new RandomGenerator(mockRandom.Object);

      // Act
      double result = subject.GetRandomSpendingMoney(startAmount);

      // Assert
      Assert.AreEqual(expected, result);
    }



  }
}
