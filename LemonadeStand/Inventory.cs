﻿namespace LemonadeStand
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

    // todo: test this
    public bool IsEnoughInventory(Recipe recipe)
    {
      isEnough = true;
      if (!(recipe.sugarCubesPerCup >= this.sugarCubes.quantity))
      {
        isEnough = false;
      }
      else if (!(recipe.lemonsPerCup >= this.lemons.quantity))
      {
        isEnough = false;
      }
      else if (!(recipe.iceCubesPerCup >= this.iceCubes.quantity))
      {
        isEnough = false;
      }
      else if (this.cups.quantity <= 0)
      {
        isEnough = false;
      }
      else
      {
        isEnough = true;
      }

      return isEnough;
    }

  }
}