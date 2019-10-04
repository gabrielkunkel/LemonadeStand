using System;

namespace LemonadeStand
{
  public class Inventory
  {
    public bool isEnough;
    public ItemStore lemons;
    public ItemStore iceCubes;
    public ItemStore cups;
    public ItemStore sugarCubes;

    public Inventory()
    {
      this.lemons = new ItemStore("lemons", 0.60);
      this.iceCubes = new ItemStore("ice cubes", 0.05);
      this.cups = new ItemStore("cups", 0.10);
      this.sugarCubes = new ItemStore("sugar cubes", 0.15);
    }

    public bool IsEnoughInventory(Recipe recipe)
    {
      if (!(recipe.sugarCubesPerCup < this.sugarCubes.quantity))
      {
        return false;
      }
      if (!(recipe.lemonsPerCup < this.lemons.quantity))
      {
        return false;
      }
      if (!(recipe.iceCubesPerCup < this.iceCubes.quantity))
      {
        return false;
      }
      if (!(this.cups.quantity > 0))
      {
        return false;
      }

      return true;
    }

    public void AddToInventory(int sugarCubes, int lemons, int iceCubes, int cups)
    {
      this.sugarCubes.IncrceaseQuantity(sugarCubes);
      this.lemons.IncrceaseQuantity(lemons);
      this.iceCubes.IncrceaseQuantity(iceCubes);
      this.cups.IncrceaseQuantity(cups);
    }

    // todo: write test for GetTotalCost
    public double GetTotalCost(int sugarCubes, int lemons, int iceCubes, int cups)
    {
      double sugarCubesCost = this.sugarCubes.cost * sugarCubes;
      double lemonsCost = this.lemons.cost * lemons;
      double iceCubesCost = this.iceCubes.cost * iceCubes;
      double cupsCost = this.cups.cost * cups;
      double totalCost = sugarCubesCost + lemonsCost + iceCubesCost + cupsCost;
      return totalCost;
    }

    public void ReduceInventoryByCurrentRecipe(int totalCups, Recipe currentRecipe)
    {
      lemons.quantity -= currentRecipe.lemonsPerCup * Convert.ToDouble(totalCups);
      iceCubes.quantity -= currentRecipe.iceCubesPerCup * Convert.ToDouble(totalCups);
      sugarCubes.quantity -= currentRecipe.sugarCubesPerCup * Convert.ToDouble(totalCups);
      cups.quantity -= totalCups;
    }

  }
}