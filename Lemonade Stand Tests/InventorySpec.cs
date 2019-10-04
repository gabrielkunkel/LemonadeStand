using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LemonadeStand;

namespace Lemonade_Stand_Tests
{
  [TestClass]
  public class InventorySpec
  {
    [TestMethod]
    public void IsEnoughInventory_InventorySetLarge_ReturnTrue()
    {
      Recipe recipe = new Recipe();
      Inventory inventory = new Inventory();
      inventory.AddToInventory(1000, 1000, 1000, 1000);

      bool isEnough = inventory.IsEnoughInventory(recipe);

      Assert.AreEqual(true, isEnough);
    }

    [TestMethod]
    public void IsEnoughInventory_InventorySetZero_ReturnFalse()
    {
      Recipe recipe = new Recipe();
      Inventory inventory = new Inventory();
      inventory.AddToInventory(0, 0, 0, 0);

      bool isEnough = inventory.IsEnoughInventory(recipe);

      Assert.AreEqual(false, isEnough);
    }

    [TestMethod]
    public void IsEnoughInventory_LemonsSetZero_ReturnFalse()
    {
      Recipe recipe = new Recipe();
      Inventory inventory = new Inventory();
      inventory.AddToInventory(1000, 0, 1000, 1000);

      bool isEnough = inventory.IsEnoughInventory(recipe);

      Assert.AreEqual(false, isEnough);
    }

    [TestMethod]
    public void IsEnoughInventory_SugarCubesSetZero_ReturnFalse()
    {
      Recipe recipe = new Recipe();
      Inventory inventory = new Inventory();
      inventory.AddToInventory(0, 1000, 1000, 1000);

      bool isEnough = inventory.IsEnoughInventory(recipe);

      Assert.AreEqual(false, isEnough);
    }

    [TestMethod]
    public void IsEnoughInventory_IceCubesSetZero_ReturnFalse()
    {
      Recipe recipe = new Recipe();
      Inventory inventory = new Inventory();
      inventory.AddToInventory(1000, 1000, 0, 1000);

      bool isEnough = inventory.IsEnoughInventory(recipe);

      Assert.AreEqual(false, isEnough);
    }

    [TestMethod]
    public void IsEnoughInventory_Cups_ReturnFalse()
    {
      Recipe recipe = new Recipe();
      Inventory inventory = new Inventory();
      inventory.AddToInventory(1000, 1000, 1000, 0);

      bool isEnough = inventory.IsEnoughInventory(recipe);

      Assert.AreEqual(false, isEnough);
    }

    [TestMethod]
    public void ReduceInventoryByCurrentRecipe_DefaultRecipe_10CupsSold()
    {
      Recipe recipe = new Recipe();
      Inventory inventory = new Inventory();
      inventory.AddToInventory(1000, 1000, 1000, 1000);

      inventory.ReduceInventoryByCurrentRecipe(10, recipe);

      Assert.AreEqual(980, inventory.iceCubes.quantity);
      Assert.AreEqual(995, inventory.lemons.quantity);
      Assert.AreEqual(990, inventory.sugarCubes.quantity);
      Assert.AreEqual(990, inventory.cups.quantity);
    }

    [TestMethod]
    public void ReduceInventoryByCurrentRecipe_DefaultRecipe_0CupsSold()
    {
      Recipe recipe = new Recipe();
      Inventory inventory = new Inventory();
      inventory.AddToInventory(1000, 1000, 1000, 1000);

      inventory.ReduceInventoryByCurrentRecipe(0, recipe);

      Assert.AreEqual(1000, inventory.iceCubes.quantity);
      Assert.AreEqual(1000, inventory.lemons.quantity);
      Assert.AreEqual(1000, inventory.sugarCubes.quantity);
      Assert.AreEqual(1000, inventory.cups.quantity);
    }

  }
}
