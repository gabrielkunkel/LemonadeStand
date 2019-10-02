using LemonadeStand;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
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

    [TestMethod]
    public void GetObjectOnProbabilityFormList_WeatherObjects()
    {
      // Arrange Object List
      List<Weather> weatherConditions = new List<Weather>();
      weatherConditions.Add(new Weather("Thunderstorm", 52.7, 0.06));
      weatherConditions.Add(new Weather("Drizzle", 56.3, 0.12));
      weatherConditions.Add(new Weather("Rain", 57.2, 0.10));
      weatherConditions.Add(new Weather("Snow", 43.9, 0.02));
      weatherConditions.Add(new Weather("Clear", 70.3, 0.70));
      weatherConditions.Add(new Weather("Clouds", 62.4, 0.24));

      // Arrange Mock
      double numberGenerated = 0.40;
      Mock<Random> mockRandom = new Mock<Random>();
      mockRandom.Setup(rand => rand.NextDouble()).Returns(() => numberGenerated);
      var subject = new RandomGenerator(mockRandom.Object);

      // Arrange Expected
      List<Weather> expectedWeatherConditions = new List<Weather>();
      expectedWeatherConditions.Add(new Weather("Clear", 70.3, 0.70));

      // Act
      List<Weather> result = subject.GetObjectOnProbabilityFromList(weatherConditions);

      // Assert
      Assert.AreEqual(expectedWeatherConditions[0].condition, result[0].condition);
      Assert.AreEqual(expectedWeatherConditions[0].temperature, result[0].temperature);
      Assert.AreEqual(expectedWeatherConditions[0].probOfWeatherEnjoyment, result[0].probOfWeatherEnjoyment);
      Assert.AreEqual(expectedWeatherConditions.Count, result.Count);
    }

  }
}
