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
    public void GetRandomListMember_ListOfStrings_()
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
  }
}
