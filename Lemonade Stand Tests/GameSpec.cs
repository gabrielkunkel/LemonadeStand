using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LemonadeStand;

namespace Lemonade_Stand_Tests
{
  [TestClass]
  public class GameSpec
  {
    [TestMethod]
    public void InitialCheck_TestsWorking_GameClass()
    {
      Game testGame = new Game();
      Assert.AreEqual(5, testGame.TestVariable);

    }
  }
}
