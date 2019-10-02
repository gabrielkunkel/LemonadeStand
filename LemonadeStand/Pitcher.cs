namespace LemonadeStand
{
  public class Pitcher
  {
    public int cupsLeftInPitcher;

    public Pitcher(int cupsOfLemonade)
    {
      this.cupsLeftInPitcher = cupsOfLemonade;
    }

    public void AddMultipleCups(int cupsAdding)
    {
      this.cupsLeftInPitcher += cupsAdding;
    }

    public void SubtractMultipleCups(int cupsDebiting)
    {
      this.cupsLeftInPitcher -= cupsDebiting;
    }

  }
}
