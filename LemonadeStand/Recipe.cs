namespace LemonadeStand
{
  public class Recipe
  {
    public double price;
    public double lemonsPerCup;
    public double sugarCubesPerCup;
    public double iceCubesPerCup;

    public Recipe()
    {
      this.price = 0.25;
      this.lemonsPerCup = 0.5;
      this.sugarCubesPerCup = 1;
      this.iceCubesPerCup = 2;
    }
    
    public Recipe(double price, double lemonsPerCup, double sugarCubesPerCup, double iceCubesPerCup)
    {
      this.price = price;
      this.lemonsPerCup = lemonsPerCup;
      this.sugarCubesPerCup = sugarCubesPerCup;
      this.iceCubesPerCup = iceCubesPerCup;
    }



  }
}