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

    [TestMethod]
    public void GetDictionaryString_ReturnArrayOfStrings()
    {
      // Arrange Dictonary
      Dictionary<string, double> probabilityOfWeatherEnjoyment = new Dictionary<string, double>();
      probabilityOfWeatherEnjoyment.Add("warm", 0.48);
      probabilityOfWeatherEnjoyment.Add("hot", 0.58);
      probabilityOfWeatherEnjoyment.Add("rain", 0.10);
      probabilityOfWeatherEnjoyment.Add("cold", 0.02);
      probabilityOfWeatherEnjoyment.Add("sunny", 0.67);
      probabilityOfWeatherEnjoyment.Add("cloudy", 0.18);

      // Arrange Mock
      double numberGenerated = 0.35;
      Mock<Random> mockRandom = new Mock<Random>();
      mockRandom.Setup(rand => rand.NextDouble()).Returns(() => numberGenerated);
      var subject = new RandomGenerator(mockRandom.Object);

      // Arrange Expected
      List<string> expected = new List<string>() { "warm", "hot", "sunny" };

      // Act
      List<string> result = subject.GetDictionaryStringOnProbability(probabilityOfWeatherEnjoyment);

      // Assert
      CollectionAssert.AreEqual(expected, result);
    }

  }
}
