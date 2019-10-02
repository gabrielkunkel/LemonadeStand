namespace LemonadeStand
{
  public class ProductSupply
  {
    public int cupsOfLemonade = 0;

    public ProductSupply()
    {

    }

    public ProductSupply(int cupsOfLemonade)
    {
      this.cupsOfLemonade = cupsOfLemonade;
    }

    public void AddMultipleCups(int cupsAdding)
    {
      this.cupsOfLemonade += cupsAdding;
    }

    public void SubtractMultipleCups(int cupsDebiting)
    {
      this.cupsOfLemonade -= cupsDebiting;
    }

  }
}
