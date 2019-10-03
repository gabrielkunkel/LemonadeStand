namespace LemonadeStand
{
  public class LemonadeSupply
  {
    public int cupsOfLemonade = 0;

    public LemonadeSupply()
    {

    }

    public LemonadeSupply(int cupsOfLemonade)
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

    public bool IsThereLemonade()
    {
      return cupsOfLemonade > 0;
    }

  }
}
