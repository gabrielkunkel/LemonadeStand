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

    // todo: write test for IsEnoughInventory
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

  }
}